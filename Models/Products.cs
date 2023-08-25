using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessmet4.Models
{
    public class Products
    {

        public readonly object Cart;

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}