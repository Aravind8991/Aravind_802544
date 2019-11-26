using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TechnologyService.Context;
using MOD_TechnologyService.Models;

namespace MOD_TechnologyService.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly SkillContext _context;
        public SkillRepository(SkillContext context)
        {
            _context = context;
        }

        public void Add(Skills item)
        {
            try
            {
                _context.Skills.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string id)
        {
            try { 
            var item = _context.Skills.Find(id);
            _context.Skills.Remove(item);
            _context.SaveChanges();
        }
            catch (Exception)
            {
                throw;
            }
}

        public List<Skills> GetTechnology()
        {
            try { 
            return _context.Skills.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Skills item)
        {
            try { 
            _context.Entry(item).State =
               Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
