using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TechnologyService.Models;

namespace MOD_TechnologyService.Repositories
{
    public interface ISkillRepository
    {
        List<Skills> GetTechnology();
        void Add(Skills item);
        void Update(Skills item);
        void Delete(string id);
    }
}
