using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option, ExampleClass exampleClass)
        {
            exampleClass.Name = "Atualizada no ProjectsController";
            _option = option.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Buscar todos os projetos
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Buscar por um projeto específico
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProjectModel)
        {
            // Cadastrar um projeto
            if (createProjectModel?.Title?.Length > 50)
            {
                return BadRequest();
            }
            //return BadRequest(); ou
            return CreatedAtAction(nameof(GetById), new { id = createProjectModel?.Id }, createProjectModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProjectModel)
        {
            //Atualizar um projeto
            if (updateProjectModel?.Description?.Length > 200)
            {
                return BadRequest();
            }

            //Atualizar o projeto

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Deletar o projeto
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createCommentModel)
        {
            //Cadastrar um comentário em um projeto
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            //Iniciar um projeto
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            //Finalizar um projeto
            return NoContent();
        }

    }
}
