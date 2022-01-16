using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class MembershipBusiness : IMembershipBusiness
    {
        private readonly MembershipRepository membershipRepository = new MembershipRepository();

        public List<Membership> SearchMembership(string firstName, string lastName)
        {
            return membershipRepository.GetAllMemberships().Where(member => member.FirstName.ToUpper().Equals(firstName.ToUpper()) && member.LastName.ToUpper().Equals(lastName.ToUpper())).ToList();
        }

        public Membership GetMembershipByID(int id)
        {
            List<Membership> list = GetAllMemberships().Where(member => member.MembershipID == id).ToList();
            return list.First();
        }

        public List<Membership> GetAllMemberships()
        {
            return membershipRepository.GetAllMemberships().ToList();
        }

        public bool InsertMembership(Membership membership)
        {
            return membershipRepository.InsertMembership(membership) != 0;
        }

        public bool UpdateMembership(Membership membership, int number)
        {
            return membershipRepository.UpdateMembership(membership, number) != 0;
        }

        public bool UpdateMembershipDetails(Membership membership)
        {
            return membershipRepository.UpdateMembershipDetails(membership) != 0;
        }
    }
}
