using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace HotelManagementSystem.Entities
{
    public class Maintenance
    {
        public int MaintenanceID { get; set; }
        public string DateScheduled { get; set; } = string.Empty;
        public string? MaintenanceDescription { get; set; }
        public string status { get; set; } = string.Empty;
        public int RoomID { get; set; }

    }
}
