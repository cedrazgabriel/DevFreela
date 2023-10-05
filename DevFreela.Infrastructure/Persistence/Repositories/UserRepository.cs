using Azure.Core;
using DevFreela.Core.DTO;
using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var user = await _dbContext.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            var userModel = new UserDTO(user.FullName, user.Active, user.Skills, user.OwnedProjects, user.FreelanceProjects);

            return userModel;
        }
    }
}
