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

    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomNumber { get; set; }
        public string RoomStatus { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<Maintenance> MaintenanceList { get; set; } = new ObservableCollectionListSource<Maintenance>();
        public virtual RoomType RoomType { get; set; }
        public virtual ObservableCollectionListSource<Booking>? Bookings { get; set; } = new ObservableCollectionListSource<Booking>();

    }

}
