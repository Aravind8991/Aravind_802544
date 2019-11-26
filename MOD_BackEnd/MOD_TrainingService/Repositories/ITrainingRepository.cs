using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TrainingService.Models;

namespace MOD_TrainingService.Repositories
{
   public interface ITrainingRepository
    {
        List<Training> GetTrainings();
        void Add(Training item);
        void Update(Training item);
        void Delete(string id);
        List<Training> GetCompletedTrainings();
        List<Training> GetOnGoingTrainings();
    }
}
