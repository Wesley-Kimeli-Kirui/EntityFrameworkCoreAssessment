using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessmet4.Models
{
    public class Shipments
    {
        [Key]
        public int ShipmentId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrderId { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}