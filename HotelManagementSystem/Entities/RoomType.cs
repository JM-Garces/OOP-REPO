using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace HotelManagementSystem.Entities
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; } = string.Empty;
        public string? RoomTypeDescription { get; set; }
        public float RoomTypeRate { get; set; }
        public string RoomTypeCapacity { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<Room> Room { get; set; } = new ObservableCollectionListSource<Room>();
    }
}
