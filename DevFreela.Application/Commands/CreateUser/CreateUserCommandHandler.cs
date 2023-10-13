using DevFreela.Application.InputModels;
using DevFreela.Core.Entities;
using DevFreela.Core.Repo;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
       private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email, request.BirthDate, request.Password, request.Role);
            
            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}
