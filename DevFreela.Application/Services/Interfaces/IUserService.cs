using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        int Create(UserInputModel user);
    }
}
