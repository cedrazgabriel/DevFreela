
namespace DevFreela.Application.InputModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string? title, DateTime createdAt)
        {
            Id = id;
            Title = title;
            createdAt = createdAt;
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime createdAt { get; set; }


    }
}
