using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int BookingID { get; set; }
        public float InvoiceViolationFees { get; set; } = 0;
        public float InvoiceServiceFees { get; set; } = 0;
        public float InvoiceOvertimeFees { get; set; } = 0;
        public float InvoiceDiscount { get; set; } = 0;
        public string InvoicePaymentStatus { get; set; }
        public Booking Booking { get; set; }
        public Payment? Payment { get; set; }
    }
}
