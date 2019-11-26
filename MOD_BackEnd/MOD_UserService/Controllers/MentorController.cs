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
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("GetMentors")]
        public List<Mentor> Get()
        {
            return _repository.GetMentors();

        }

        // GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Mentor
        [HttpPost]
        [Route("AddMentor")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public string Put(string id)
        {
            _repository.BlockMentor(id);
            return "Blocked";
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("UpdateMentor/{id}")]
        public IActionResult Put(Mentor item)
        {
            _repository.Update(item);
            return Ok("Record Updated");
        }
        //put
        [HttpPut("{id}")]
        [Route("ResetPass/{Email}/{NewPass}")]
        public void ResetPassword(string Email, string NewPass)
        {
            _repository.ResetPassword(Email,NewPass);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteMentor/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
