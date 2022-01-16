using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public class CheckinBusiness : ICheckinBusiness
    {
        private readonly ICheckinRepository checkinRepository;

        public CheckinBusiness(ICheckinRepository checkinRepository)
        {
            this.checkinRepository = checkinRepository;
        }

        public bool InsertCheckin(Checkin checkin)
        {
            return checkinRepository.InsertCheckin(checkin) != 0;
        }
    }
}
