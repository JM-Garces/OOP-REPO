using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace HotelManagementSystem.Entities
{
    public class Staff
    {
        [Key]
        public int StaffID {  get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? MiddleName {  get; set; }
        public string? Suffix { get; set; }

    }
}
