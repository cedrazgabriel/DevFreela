using DevFreela.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repo
{
    public interface ISkillRepository
    {
       Task<List<SkillDTO>> GetAllAsync();
    }
}
