using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        void Add(User item);
        void Update(User item);
        void Delete(string id);
        void ResetPassword(string Email,string NewPass);
        List<Models.Mentor> SearchMentor(string Skill,string TimeSlot);
        void BlockUser(string id);
    }
}
