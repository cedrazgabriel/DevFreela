using DevFreela.Core.DTO;
using DevFreela.Core.Entities;


namespace DevFreela.Core.Repo
{
    public interface IUserRepository
    {
        Task<UserDTO> GetByIdAsync(int id);
        Task AddAsync(User user);
    }
}
