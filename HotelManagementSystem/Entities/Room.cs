using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomStatus { get; set; } = string.Empty;
        public int? RoomTypeID{ get; set; }
        public virtual RoomType RoomType { get; set; }
        //public int? MaintenanceId { get; set; }
        //public virtual Maintenance Maintenance { get; set; }

    }
}
