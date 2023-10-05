using DevFreela.Application.InputModels;
using DevFreela.Core.Repo;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectViewModel>>
    {
        private readonly IProjectRepository _projectRepository;
        public GetAllProjectsQueryHandler(IProjectRepository repository)
        {
            _projectRepository = repository;
        }
        public async Task<List<ProjectViewModel>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            var projects = await _projectRepository.GetAllAsync();

            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.Title, p.createdAt))
                .ToList();

            return projectsViewModel;
        }
    }
  
}
