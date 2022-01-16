using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface ITrainingBusiness
    {
        List<Training> GetAllTrainings();
        bool InsertTraining(Training training);
    }
}
