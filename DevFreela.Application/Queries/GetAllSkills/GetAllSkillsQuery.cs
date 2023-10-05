﻿using DevFreela.Application.ViewModels;
using DevFreela.Core.DTO;
using MediatR;


namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillDTO>>
    {
    }
}
