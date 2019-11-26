using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_UserService.Context;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserServiceContext _context;
        public UserRepository(UserServiceContext context)
        {
            _context = context;
        }

        public void Add(User item)
        {
            try { 
            _context.Users.Add(item);
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<User> GetUsers()
        {
            try { 
            return _context.Users.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(User item)
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

        public void Delete(string id)
        {
            try { 
            var item = _context.Users.Find(id);
            _context.Users.Remove(item);
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ResetPassword(string Email,string NewPass)
        {
            try { 
            var Rstpass = _context.Users.SingleOrDefault(i => i.Email==Email);
            Rstpass.Password = NewPass;
            _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Mentor> SearchMentor(string Skill, string TimeSlot)
        {
            try { 
            var mentors = _context.Mentors.Where(mentors => mentors.Skill == Skill && 
            mentors.TimeSlot == TimeSlot).ToList();
            return mentors;
            }
            catch (Exception)
            {
                throw;
            }


        }
        public void BlockUser(string id)
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

