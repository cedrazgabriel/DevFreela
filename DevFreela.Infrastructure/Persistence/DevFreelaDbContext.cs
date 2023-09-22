using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha Descrição do projeto",1,1,10000),
                new Project("Meu projeto React", "Minha Descrição do projeto",1,1,10000),
                new Project("Meu projeto Node", "Minha Descrição do projeto",1,1,10000),
            };
            Users = new List<User>
            {
                new User("Gabriel Cedraz", "cedrazteste@gmail.com", new DateTime(1999,06,21)),
                new User("José Carlos", "josecarlos@gmail.com", new DateTime(1999,06,21)),
                new User("Mariana Bahia", "maribahia@gmail.com", new DateTime(1999,06,21)),
            };
            Skils = new List<Skill>
            {
                new Skill("React JS"),
                new Skill("ASPNET Core"),
                new Skill("Node JS"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skils { get; set; }
        public List<ProjectComment>? ProjectComments { get; set; }
    }
}
