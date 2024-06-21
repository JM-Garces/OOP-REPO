using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class RoomRate
    {
        [Key]
        public int RoomRateID { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomRateTypeDay { get; set; }
        public string RoomRateDuration { get; set; }
        public float RoomRateCost { get; set; }
        public RoomType RoomType { get; set; }
    }
}
