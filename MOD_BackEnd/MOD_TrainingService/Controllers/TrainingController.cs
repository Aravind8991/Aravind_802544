using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TrainingService.Models;
using MOD_TrainingService.Repositories;

namespace MOD_TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetTrainings")]
        public IList<Training> Get()
        {
            return _repository.GetTrainings();
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetCompletedTrainings")]
        public IList<Training> GetCompletedTraining()
        {
            return _repository.GetCompletedTrainings();
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetOnGoingTrainings")]
        public IList<Training> GetOnGoingTraining()
        {
            return _repository.GetOnGoingTrainings();
        }

        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.Add(item);
            return Ok("New Training  Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("UpdateTraining/{id}")]
        public void Put(Training item)
        {
            _repository.Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteTraining/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
