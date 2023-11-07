using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using NSubstitute;
namespace DevFreela.UnitTests.Application.Queries;

public class GetAllProjectsCommandHandlerTests
{
    [Fact]
    public async Task ThreeProjectsExist_Executed_ReturnThreeProjectVieeModels()
    {
        //Arrange
        var projects = new List<Project>()
        {
            new Project("Projeto Teste", "Descrição teste", 1, 2, 10000),
            new Project("Projeto Teste 2", "Descrição teste 2", 1, 2, 20000),
            new Project("Projeto Teste 3", "Descrição teste 3", 1, 2, 30000),
        };
        
        var projectRepositoryMock = Substitute.For<IProjectRepository>();
        projectRepositoryMock.GetAllAsync().Returns(projects);

        var getAllProjectsQuery = new GetAllProjectsQuery("");
        var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock);

        //Act
        var projectsViewModel = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());
        
        //Assert
        Assert.NotNull(projectsViewModel);
        Assert.NotEmpty(projectsViewModel);
        Assert.Equal(3, projectsViewModel.Count);
    }
}