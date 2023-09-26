using DevFreela.Application.InputModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void CreateComment(CreateCommandInputModel inputModel);
        void Delete(int id);
        void Start (int id);
        void Finish(int id);
    }
}
