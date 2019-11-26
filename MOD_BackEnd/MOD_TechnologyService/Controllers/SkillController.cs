using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TechnologyService.Models;
using MOD_TechnologyService.Repositories;

namespace MOD_TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _repository;
        public SkillController(ISkillRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skill
        [HttpGet]
        [Route("GetTechnology")]
        public IList<Skills> Get()
        {
            return _repository.GetTechnology();
        }

        // GET: api/Skill/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Skill
        [HttpPost]
        [Route("AddTechnology")]
        public IActionResult Post([FromBody]Skills item)
        {
            _repository.Add(item);
            return Ok("Record Added");

        }

        // PUT: api/Skill/5
        [HttpPut("{id}")]
        [Route("UpdateTechnology/{id}")]
        public IActionResult Put(Skills item)
        {
            _repository.Update(item);
            return Ok("Record Updated");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteTechnology/{id}")]
        public IActionResult Delete(string id)
        { 
            _repository.Delete(id);
            return Ok("Record Deleted");
        }
    }
}
