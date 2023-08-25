using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Assessmet4.Models;

namespace Assessmet4.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public Payments Payment { get; set; }
        public int? ShipmentId { get; set; }
        public Shipments Shipment { get; set; }
        public int? PaymentId { get; set; }
    }
}