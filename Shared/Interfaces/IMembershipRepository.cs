using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface IMembershipRepository
    {
        List<Membership> GetAllMemberships();
        int InsertMembership(Membership membership);
        int UpdateMembership(Membership membership, int number);
        int UpdateMembershipDetails(Membership membership);
    }
}
