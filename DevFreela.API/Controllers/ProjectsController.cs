using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Commands.DeleteProject;
using DevFreela.Application.Commands.FinishProject;
using DevFreela.Application.Commands.StartProject;
using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetProjectById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
     
        private readonly IMediator _mediator;
       
        public ProjectsController(IMediator mediator)
        {
     
          _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "client, freelancer")]
        public async Task<IActionResult> Get(string query)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                
                return BadRequest(messages);
            }
            
            var projectQuery = new GetAllProjectsQuery(query);
            var projects = await _mediator.Send(projectQuery);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "client, freelancer")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetProjectByIdQuery(id);
            var project = await _mediator.Send(query);

            if(project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
        {
            var idProject = await _mediator.Send(command);
    
            return CreatedAtAction(nameof(GetById), new{ id = idProject } , command);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
        {
            //Atualizar um projeto
            if (command?.Description?.Length > 200)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
        
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProjectCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        [Authorize(Roles = "client, freelancer")]
        public async Task<IActionResult> PostComment(int id, [FromBody] CreateComentCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id}/start")]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Start(int id)
        {
            await _mediator.Send(new StartProjectCommand(id));
     
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Finish(int id)
        {
           await _mediator.Send(new FinishProjectCommand(id));
            return NoContent();
        }

    }
}
