
namespace DevFreela.Application.InputModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string? title, DateTime createdAt)
        {
            Title = title;
            this.createdAt = createdAt;
        }

        public string? Title { get; set; }
        public DateTime createdAt { get; set; }


    }
}
