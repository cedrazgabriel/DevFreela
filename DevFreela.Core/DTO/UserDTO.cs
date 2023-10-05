using DevFreela.Core.Entities;

namespace DevFreela.Core.DTO
{
    public class UserDTO
    {
        public UserDTO(string? fullName, bool active, List<UserSkill>? skills, List<Project>? ownedProjects, List<Project>? freelanceProjects)
        {
            FullName = fullName;
            Active = active;
            Skills = skills;
            OwnedProjects = ownedProjects;
            FreelanceProjects = freelanceProjects;
        }

        public string? FullName { get; private set; }
        public bool Active { get; set; }
        public List<UserSkill>? Skills { get; private set; }
        public List<Project>? OwnedProjects { get; private set; }
        public List<Project>? FreelanceProjects { get; private set; }
    }
}
