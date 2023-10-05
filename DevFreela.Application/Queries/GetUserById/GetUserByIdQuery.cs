﻿using DevFreela.Application.ViewModels;
using DevFreela.Core.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserByIdQuery : IRequest<UserDTO>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
