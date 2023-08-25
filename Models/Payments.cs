using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessmet4.Models
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Payment { get; set; }


        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}


