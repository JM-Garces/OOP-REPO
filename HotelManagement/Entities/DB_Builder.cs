using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using HotelManagement.Classes;

namespace HotelManagement.Entities
{
    public class DB_Builder : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source = HotelDatabase.db");

        ValuesForEnum checker = new ValuesForEnum();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { RoomTypeID = 1, RoomTypeName = "Standard", RoomTypeCapacity = "1-2" },
                new RoomType { RoomTypeID = 2, RoomTypeName = "Deluxe", RoomTypeCapacity = "2-3" },
                new RoomType { RoomTypeID = 3, RoomTypeName = "Suite", RoomTypeCapacity = "3-4" }
                );

            modelBuilder.Entity<Room>().HasData();
            modelBuilder.Entity<RoomRate>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<Maintenance>();
            modelBuilder.Entity<Invoice>();
            modelBuilder.Entity<Guest>();
            modelBuilder.Entity<FeedBack>();

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, EmployeeFirstName = "Rin", EmployeeLastName = "Katagiri", EmployeeSex = checker.CheckValueString("Mali"), EmployeeBirthDate = "30/32/24", EmployeeBarangay = "175", EmployeeCity = "Nigata"
                               ,EmployeeEmailAddress = "Something@gmail.com", EmployeeHireDate = "40/60/20", EmployeeProvince = "Hulaan nyo", EmployeePhoneNumber = "09323232", EmployeeStreetNo = "69420", EmployeeMiddleName = "N/A"
                               ,EmployeeSuffix = ".", EmployeeZipCode = "3232", EmployeePosition = checker.CheckValueString("RoOm AtTEnDaNT")}
                );

            modelBuilder.Entity<EmergencyContact>();
            modelBuilder.Entity<Booking>();

            modelBuilder.Entity<Account>().HasData(
                new Account { AccountID = 1, EmployeeID = 1, AccountUserName = "NalZero", AccountPassword = "Nal", AccountRole = checker.CheckValueString("Staff"), AccountStatus = checker.CheckValueString("")   }
                );

        }
    }
}
