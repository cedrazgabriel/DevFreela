using DevFreela.Application.InputModels;
using DevFreela.Core.DTO;
using DevFreela.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<Project>
    {
        public GetProjectByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
