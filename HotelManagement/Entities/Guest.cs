using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelManagement.Entities
{

    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public int EmergencyContactID { get; set; }
        public string GuestFirstName { get; set; } = string.Empty;
        public string? GuestMiddleName { get; set; }
        public string GuestLastName { get; set; } = string.Empty;
        public string? GuestSuffix { get; set; }
        public string GuestSex { get; set; } = string.Empty;
        public string GuestBirthDate { get; set; } = string.Empty;
        public string GuestPhoneNumber { get; set; } = string.Empty;
        public string GuestEmailAddress { get; set; } = string.Empty;
        public string GuestNationality { get; set; } = string.Empty;
        public string GuestStatus { get; set; } = string.Empty;
        public bool IsSeniorCitizen { get; set; } = false;
        public string? SeniorCitizenNo { get; set; }
        public FeedBack? FeedBack { get; set; }
        public ObservableCollectionListSource<Booking> Bookings { get; set; }
        [ForeignKey("EmergencyContactID")]
        public EmergencyContact? EmergencyContact { get; set; }
    }
}
