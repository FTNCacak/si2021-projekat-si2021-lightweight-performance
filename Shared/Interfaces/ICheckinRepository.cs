using Shared.Models;

namespace Shared.Interfaces
{
    public interface ICheckinRepository
    {
        int InsertCheckin(Checkin checkin);
    }
}
