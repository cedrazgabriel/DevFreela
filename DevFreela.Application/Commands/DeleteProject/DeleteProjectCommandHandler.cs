using DevFreela.Core.Repo;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Commands.DeleteProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
       
        public DeleteProjectCommandHandler(IProjectRepository respository)
        {
            _projectRepository = respository;
          
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            if (project != null)
            {
               project.Cancel();
               await _projectRepository.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
