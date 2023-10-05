using DevFreela.Core.DTO;
using DevFreela.Core.Entities;

namespace DevFreela.Core.Repo
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task AddAsync(Project project);
        Task StartAsync(Project project);
        Task SaveChangesAsync();
        Task AddProjectCommentAsync(ProjectComment projectComment);
       
    }
}
