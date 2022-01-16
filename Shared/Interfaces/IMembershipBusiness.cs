using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface IMembershipBusiness
    {
        List<Membership> SearchMembership(string firstName, string lastName);
        Membership GetMembershipByID(int id);
        List<Membership> GetAllMemberships();
        bool InsertMembership(Membership membership);
        bool UpdateMembership(Membership membership, int number);
        bool UpdateMembershipDetails(Membership membership);
    }
}
