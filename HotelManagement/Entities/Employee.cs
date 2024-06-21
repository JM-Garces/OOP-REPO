using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

#nullable enable
namespace HotelManagement.Entities
{
 
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; } = string.Empty;
        public string? EmployeeMiddleName { get; set; }
        public string EmployeeLastName {  get; set; } = string.Empty;
        public string? EmployeeSuffix {  get; set; }
        public string EmployeeSex {  get; set; } = string.Empty;
        public string EmployeeBirthDate {  get; set; } = string.Empty;
        public string EmployeeStreetNo {  get; set; } = string.Empty;
        public string EmployeeZipCode { get; set; } = string.Empty;
        public string EmployeeBarangay {  get; set; } = string.Empty;
        public string EmployeeCity {  get; set; } = string.Empty;
        public string EmployeeProvince {  get; set; } = string.Empty;
        public string EmployeePhoneNumber {  get; set; } = string.Empty;
        public string EmployeeEmailAddress {  get; set; } = string.Empty;
        public string EmployeeHireDate { get; set; } = string.Empty;  
        public string EmployeePosition {  get; set; } = string.Empty;
        public string EmployeeStatus {  get; set; } = string.Empty;
        public Account? Account { get; set; }
        public ObservableCollectionListSource<Booking>? Bookings { get; set; } = new ObservableCollectionListSource<Booking>();
    }
}
