using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string? fullName, bool active, List<UserSkill>? skills, List<Project>? ownedProjects, List<Project>? freelanceProjects)
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
