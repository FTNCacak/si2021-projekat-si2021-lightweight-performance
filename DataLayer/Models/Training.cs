using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Training
    {
        public DateTime Appointment { get; set; }
        public int MembershipID { get; set; }
        public int EmployeeID { get; set; }
        public string Type { get; set; }
    }
}
