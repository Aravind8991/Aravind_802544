using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_UserService.Context;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserServiceContext _context;
        public MentorRepository(UserServiceContext context)
        {
            _context = context;
        }

        public void Add(Mentor item)
        {
            try { 
            _context.Mentors.Add(item);
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
            var item = _context.Mentors.Find(id);
            _context.Mentors.Remove(item);
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Mentor> GetMentors()
        {
            try { 
            return _context.Mentors.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ResetPassword(string Email, string NewPass)
        {
            try { 
            var Rstpass = _context.Mentors.SingleOrDefault(i => i.Email == Email);
            Rstpass.Password = NewPass;
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Mentor item)
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
        public void BlockMentor(string id)
        {
            try { 
            var item = _context.Users.Find(id);
            if (item.Active)
            {
                item.Active = !item.Active;
            }
            else
            {
                item.Active = !item.Active;
            }
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
