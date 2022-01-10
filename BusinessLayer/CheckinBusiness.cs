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

        public List<Checkin> GetAllCheckins()
        {
            return checkinRepository.GetAllCheckins();
        }

        public bool InsertCheckin(Checkin checkin)
        {
            return checkinRepository.InsertCheckin(checkin) != 0;
        }
    }
}
