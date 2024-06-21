using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
 
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public string BookingCheckInDate { get; set; }
        public string BookingCheckOutDate { get; set;}
        public string BookingStatus { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public Invoice Invoice { get; set; }
        public Employee Employee { get; set; }
    }
}
