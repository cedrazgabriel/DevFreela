using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using MediatR;

namespace DevFreela.Application.Commands.CreateComment
{
    public class CreateComentCommandHandler : IRequestHandler<CreateComentCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public CreateComentCommandHandler(IProjectRepository repository)
        {
            _projectRepository = repository;
        }
        public async Task<Unit> Handle(CreateComentCommand request, CancellationToken cancellationToken)
        {
            var comment = new ProjectComment(request.Content, request.IdProject, request.IdUser);
           
            await _projectRepository.AddProjectCommentAsync(comment);

            return Unit.Value;
        }
    }
}
