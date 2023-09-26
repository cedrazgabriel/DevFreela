using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(UserInputModel userInputModel)
        {
            var user = new User(userInputModel.FullName, userInputModel.Email, userInputModel.BirthDate);

            return user.Id;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.Where(u => u.Id == id).FirstOrDefault();

            var userModel = new UserViewModel(user.FullName, user.Active, user.Skills, user.OwnedProjects, user.FreelanceProjects);

            return userModel;
        }
    }
}
