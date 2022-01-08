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
    public class CheckinBusiness : ICheckinBusiness
    {
        private readonly CheckinRepository checkinRepository = new CheckinRepository();
    }
}
