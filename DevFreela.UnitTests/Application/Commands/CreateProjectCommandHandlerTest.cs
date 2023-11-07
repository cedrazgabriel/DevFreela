using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using NSubstitute;

namespace DevFreela.UnitTests.Application.Commands;

public class CreateProjectCommandHandlerTest
{
    [Fact]
    public async Task InputDataIsOk_Executed_ReturnProjectId()
    {
        //Arrange
       var projectRepositoryMock = Substitute.For<IProjectRepository>();
        
       var createProjectCommand = new CreateProjectCommand
       {
           Title = "Titulo teste",
           Description = "Descrição teste",
           TotalCost = 3000,
           IdClient = 1,
           IdFreelancer = 2
       };

       var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepositoryMock);
       //Act
       
       var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());
       
       //Assert
        await projectRepositoryMock.Received(1).AddAsync(Arg.Any<Project>());
         Assert.Equal(2, id);
         // Verificar se o repositório recebeu a chamada addasync
         
    }
}