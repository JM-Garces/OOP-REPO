using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public float PaymentAmount { get; set; }
        public string PaymentDate { get; set; }
        public Invoice Invoice { get; set; }  
    }
}
