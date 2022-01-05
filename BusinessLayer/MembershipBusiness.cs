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
        private readonly IMembershipRepository membershipRepository;

        public MembershipBusiness(IMembershipRepository membershipRepository)
        {
            this.membershipRepository = membershipRepository;
        }
    }
}
