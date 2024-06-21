using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

#nullable enable
namespace HotelManagement.Entities
{
    public class Maintenance
    {
        [Key]
        public int MaintenanceID { get; set; }
        public int RoomID { get; set; }
        public string DateScheduled { get; set; } = string.Empty;
        public string MaintenanceDescription { get; set; } = string.Empty;
        public string MaitenanceStatus { get; set; } = string.Empty;
        public Room Room { get; set; }
    }
}
