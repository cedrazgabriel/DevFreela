using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Repo;
using Moq;

namespace DevFreela.UnitTests.Application.Commands;

public class CreateProjectCommandHandlerTest
{
    [Fact]
    public async Task InputDataIsOk_Executed_ReturnProjectId()
    {
        //Arrange
        var projectRepositoryMock = new Mock<IProjectRepository>();
        
       var createProjectCommand = new CreateProjectCommand
       {
           Title = "Titulo teste",
           Description = "Descrição teste",
           TotalCost = 3000,
           IdClient = 1,
           IdFreelancer = 2
       };

       var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepositoryMock.Object);
       //Act
       
       var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());
       
       //Assert
      
        Assert.True(id >= 0);
        
    }
}