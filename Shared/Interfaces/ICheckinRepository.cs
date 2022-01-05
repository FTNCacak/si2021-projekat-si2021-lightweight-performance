using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ICheckinRepository
    {
        List<Checkin> GetAllCheckins();
        int InsertCheckin(Checkin checkin);
        int UpdateCheckin(Checkin checkin);
        int DeleteCheckin(DateTime CheckinDate, int MembershipID);
    }
}
