using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface ITrainingRepository
    {
        List<Training> GetAllTrainings();
        int InsertTraining(Training training);
    }
}
