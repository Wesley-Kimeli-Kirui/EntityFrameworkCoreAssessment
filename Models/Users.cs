using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessmet4.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Cart Cart { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}

