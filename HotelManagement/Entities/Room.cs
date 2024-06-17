using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public string RoomStatus { get; set; } = string.Empty;
        public int? RoomTypeID{ get; set; }
        public virtual RoomType RoomType { get; set; }
        //public int? MaintenanceId { get; set; }
        //public virtual Maintenance Maintenance { get; set; }

    }
}
