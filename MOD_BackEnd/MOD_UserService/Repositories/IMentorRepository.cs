using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public interface IMentorRepository
    {
        List<Mentor> GetMentors();
        void Add(Mentor item);
        void Update(Mentor item);
        void Delete(string id);
        void ResetPassword(string Email,string NewPass);
        void BlockMentor(string id);
    }
}
