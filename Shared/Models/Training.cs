using System;

namespace Shared.Models
{
    public class Training
    {
        public DateTime Appointment { get; set; }
        public int MembershipID { get; set; }
        public int EmployeeID { get; set; }
        public string Type { get; set; }
    }
}
