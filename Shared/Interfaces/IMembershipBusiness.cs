using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IMembershipBusiness
    {
        List<Membership> SearchMembership(string firstName, string lastName);
        Membership GetMembershipByID(int id);
        List<Membership> GetAllMemberships();
        bool InsertMembership(Membership membership);
        bool UpdateMembership(Membership membership, int number);
    }
}
