using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace HotelManagement.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; } = string.Empty;
        public string RoomTypeCapacity { get; set; } = string.Empty;
        public string RoomTypeDescription { get; set; } = string.Empty;
        public string RoomTypeAmenties { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<Room> Rooms { get; set; } = new ObservableCollectionListSource<Room>();
        public virtual ObservableCollectionListSource<RoomRate> RoomRates { get; set; } = new ObservableCollectionListSource<RoomRate>();
    }
}
