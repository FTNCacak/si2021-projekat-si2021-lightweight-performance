using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ITrainingRepository
    {
        List<Training> GetAllTrainings();
        int InsertTraining(Training training);
        int UpdateTraining(Training training);
        int DeleteTraining(DateTime Appointment, int MembershipID, int EmployeeID);
    }
}
