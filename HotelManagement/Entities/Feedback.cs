using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{

    public class FeedBack
    {
        [Key]
        public int FeedBackID { get; set; }
        public int GuestID { get; set; }
        public string FeedBackDate { get; set; } = string.Empty;
        public string FeedBackDetails { get; set; } = string.Empty;
        public int FeedBackRating { get; set; }
        public Guest Guest { get; set; }
    }
}
