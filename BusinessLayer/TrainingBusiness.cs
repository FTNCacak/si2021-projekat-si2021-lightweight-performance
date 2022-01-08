using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TrainingBusiness : ITrainingBusiness
    {
        private readonly ITrainingRepository trainingRepository = new TrainingRepository();
    }
}
