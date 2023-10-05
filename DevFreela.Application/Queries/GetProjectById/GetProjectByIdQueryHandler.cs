using DevFreela.Core.DTO;
using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using MediatR;


namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, Project>
    {
        private readonly IProjectRepository _projectRepository;
        public GetProjectByIdQueryHandler(IProjectRepository repository)
        {
            _projectRepository = repository;
        }
        public async Task<Project> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
           return await _projectRepository.GetByIdAsync(request.Id);
        }
    }
    
}
