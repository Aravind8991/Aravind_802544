using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_UserService.Models;
using MOD_UserService.Repositories;

namespace MOD_UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        [Route("GetUsers")]
        public List<User> Get()
        {
            return _repository.GetUsers();
        }

        // GET: api/User/5
       
        [Route("SearchMentor/{Skill}/{TimeSlot}")]

        public List<Mentor> Get(string Skill, string TimeSlot)
        {
            return _repository.SearchMentor(Skill,TimeSlot);
        }

        // POST: api/User
        [HttpPost]
        [Route("AddUser")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("UpdateUser/{id}")]
        public void Put(User item)
        {
            _repository.Update(item);
        }
        // PUT
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public string Put(string id)
        {
            _repository.BlockUser(id);
            return "Blocked";
        }
        //put
        [HttpPut("{id}")]
        [Route("ResetPass/{Email}/{NewPass}")]
        public void  ResetPassword(string Email, string NewPass)
        {
            _repository.ResetPassword(Email,NewPass);
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteUser/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
        
    }
}
