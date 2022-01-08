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
    public class MembershipBusiness : IMembershipBusiness
    {
        readonly MembershipRepository membershipRepository = new MembershipRepository();

        public List<Membership> GetAllMemberships()
        {
            return membershipRepository.GetAllMemberships();
        }

        public bool InsertMembership(Membership membership)
        {
            return membershipRepository.InsertMembership(membership) != 0;
        }
    }
}
