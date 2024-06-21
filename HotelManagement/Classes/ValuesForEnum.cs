using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Classes
{
    public class ValuesForEnum
    {
        public ValuesForEnum() { }

        public string[] ACCOUNTROLE = ["ADMIN", "STAFF"];
        public string[] ACCOUNTSTATUS = ["ACTIVE", "INACTIVE", "SUSPENDED", "DEACTIVATED"];
        public string[] BOOKINGSTATUS = ["RESERVED", "CONFIRMED", "CANCELLED"];
        public string[] INVOICEPAYMENTSTATUS = ["PENDING", "PAID", "REFUNDED", "OVERDUE"];
        public string[] PERSONSEX = ["MALE", "FEMALE", "INTERSEX"];
        public string[] GUESTSTATUS = ["CHECKED IN", "CHECKED OUT", "BLACK LISTED"];
        public string[] CONTACTRELATIONSHIP = ["FAMILY", "FRIEND", "COLLEAGUE", "PARTNER", "OTHER"];
        public string[] ROOMTYPENAME = ["STANDARD", "DELUXE", "SUITE"];
        public string[] ROOMSTATUS = ["AVAILABLE", "OCCUPIED", "RESERVED", "UNDER MAINTENANCE"];
        public string[] MAITENANCESTATUS = ["SCHEDULED", "IN PROGRESS", "COMPLETED", "CANCELLED"];
        public string[] EMPLOYEEPOSITION = ["MANAGER", "OWNER", "RECEPTIONIST", "ROOM ATTENDANT"];
        public string[] EMPLOYEESTATUS = ["ACTIVE", "ON LEAVE", "RESIGNED", "TERMINATED"];
        public int[] FEEDBACKRATING = [1, 2, 3, 4, 5];

        public string CheckValueString(string StrValue)
        {
    
            StrValue = StrValue.Trim().ToUpper();

            if (ACCOUNTROLE.Contains(StrValue) || ACCOUNTSTATUS.Contains(StrValue) || BOOKINGSTATUS.Contains(StrValue)
                || INVOICEPAYMENTSTATUS.Contains(StrValue) || PERSONSEX.Contains(StrValue) || GUESTSTATUS.Contains(StrValue)
                || CONTACTRELATIONSHIP.Contains(StrValue) || ROOMTYPENAME.Contains(StrValue) || ROOMSTATUS.Contains(StrValue)
                || MAITENANCESTATUS.Contains(StrValue) || EMPLOYEEPOSITION.Contains(StrValue) || EMPLOYEESTATUS.Contains(StrValue)
                || EMPLOYEESTATUS.Contains(StrValue)) return StrValue;

            return string.Empty;
        }

        public int CheckValueInt(int Rating)
        {
            if (Rating < 1 || Rating > 5)
                return 1;

            return Rating;
        }

    }
}
