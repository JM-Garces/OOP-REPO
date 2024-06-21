using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public int EmployeeID { get; set; }
        public string AccountUserName { get; set; }
        public string AccountPassword { get; set; }
        public string AccountRole { get; set; }
        public string AccountStatus { get; set; }
        public Employee Employee { get; set; }
    }
}
