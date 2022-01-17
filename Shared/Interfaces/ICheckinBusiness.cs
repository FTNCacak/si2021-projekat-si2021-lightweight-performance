using Shared.Models;

namespace Shared.Interfaces
{
    public interface ICheckinBusiness
    {
        bool InsertCheckin(Checkin checkin);
    }
}
