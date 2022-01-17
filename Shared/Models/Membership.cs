using System;

namespace Shared.Models
{
    public class Membership
    {
        public int MembershipID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Note { get; set; }
    }
}
