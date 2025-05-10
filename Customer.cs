using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.models
{
    class Customer
    {
        public int CustomerID { get; set; }
        [MaxLength(100)]
        [Required]
        [Unicode]
        public string Name { get; set; }
        [MaxLength(80)]
        [Required]
        [Unicode(false)]
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; } = string.Empty;


        public ICollection<Seles> Sales { get; set; } = new HashSet<Seles>();
    }
}
