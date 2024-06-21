using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelManagement.Entities
{
    public class EmergencyContact
    {
        [Key]
        public int EmergencyContactID { get; set; }
        public string EC_FirstName { get; set; }
        public string? EC_MiddleName { get; set; }
        public string EC_LastName { get; set; }
        public string? EC_Suffix { get; set; }
        public string EC_PhoneNumber { get; set; }
        public string EC_EmailAddress { get; set; }
        public string EC_Relationship { get; set; }
        public ObservableCollectionListSource<Guest> Guests { get; set; } = new ObservableCollectionListSource<Guest>();
    }
}
