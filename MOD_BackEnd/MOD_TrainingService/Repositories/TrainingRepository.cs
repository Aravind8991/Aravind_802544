using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TrainingService.Context;
using MOD_TrainingService.Models;

namespace MOD_TrainingService.Repositories
{
    public class TrainingRepository:ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }

        public void Add(Training item)
        {
            try
            {
                _context.Trainings.Add(item);
                _context.SaveChanges();
            }
            catch(Exception){
                throw;
            }
        }

        public void Delete(string id)
        {
            try { 
            var item = _context.Trainings.Find(id);
            _context.Trainings.Remove(item);
            _context.SaveChanges();
        }
            catch (Exception)
            {
                throw;
            }
}

        public List<Training> GetTrainings()
        {
            try { 
            return _context.Trainings.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetCompletedTrainings()
        {
            try { 
            var ts = _context.Trainings.Where( ts=> ts.status == "completed" && ts.Progress=="100%").ToList();
            return ts;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Training> GetOnGoingTrainings()
        {
            try { 
            var ts = _context.Trainings.Where(ts => ts.status == "ongoing" && ts.Progress!="100%" ).ToList();
            return ts;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Training item)
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
