using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore = Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Entities
{
    public class RoomContext : EFCore.DbContext
    {
        public EFCore.DbSet<Room> Rooms { get; set; }
        public EFCore.DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnConfiguring(EFCore.DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source = Hotel Database.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { RoomTypeID = 1, RoomTypeName = "Standard", RoomTypeRate = 600, RoomTypeCapacity = "1-2" },
                new RoomType { RoomTypeID = 2, RoomTypeName = "Deluxe", RoomTypeRate = 800, RoomTypeCapacity = "2-3" },
                new RoomType { RoomTypeID = 3, RoomTypeName = "Suite", RoomTypeRate = 1_100, RoomTypeCapacity = "3-4" }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room { RoomNumber = 1, RoomStatus = "Available", RoomTypeID = 1 },
                new Room { RoomNumber = 2, RoomStatus = "Occupied", RoomTypeID = 1 },
                new Room { RoomNumber = 3, RoomStatus = "Reserved", RoomTypeID = 1 },
                new Room { RoomNumber = 4, RoomStatus = "UnderMaintenance", RoomTypeID = 1 },
                new Room { RoomNumber = 5, RoomStatus = "Available", RoomTypeID = 2 },
                new Room { RoomNumber = 6, RoomStatus = "Occupied", RoomTypeID = 2 },
                new Room { RoomNumber = 7, RoomStatus = "Reserved", RoomTypeID = 2 },
                new Room { RoomNumber = 8, RoomStatus = "UnderMaintenance", RoomTypeID = 2 },
                new Room { RoomNumber = 9, RoomStatus = "Available", RoomTypeID = 3 },
                new Room { RoomNumber = 10, RoomStatus = "Occupied", RoomTypeID = 3 },
                new Room { RoomNumber = 11, RoomStatus = "Reserved", RoomTypeID = 3 },
                new Room { RoomNumber = 12, RoomStatus = "UnderMaintenance", RoomTypeID = 3 }
                );
        }
    }
}
