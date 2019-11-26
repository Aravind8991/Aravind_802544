using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_AuthenticateService.Context;
using MOD_AuthenticateService.Models;

namespace MOD_AuthenticateService.Repositories
{
    public class LoginRepository : IloginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public bool MentorLogin(string mid, string pwd)
        {
            try { 
            Mentor obj = _context.Mentors.SingleOrDefault(data => data.MentorId == mid && data.Password == pwd);
            {
                if (obj != null)
                    return true;
                else
                    return false; 
            }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UserLogin(string uid, string pwd)
        {
            try { 
            User obj = _context.Users.SingleOrDefault(Data => Data.UserId == uid && Data.Password == pwd);
            {
                if (obj != null)
                    return true;
                else
                    return false;
            }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
