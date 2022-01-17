using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class TrainingBusiness : ITrainingBusiness
    {
        private readonly ITrainingRepository trainingRepository;

        public TrainingBusiness(ITrainingRepository trainingRepository)
        {
            this.trainingRepository = trainingRepository;
        }

        public List<Training> GetAllTrainings()
        {
            return trainingRepository.GetAllTrainings();
        }

        public bool InsertTraining(Training training)
        {
            return trainingRepository.InsertTraining(training) != 0;
        }
    }
}
