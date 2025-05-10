using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.models
{
    class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        [Required]
        [Unicode]
        public string Name { get; set; }
        public double quantity { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; } = "No ndescription";
        public ICollection<Seles> Sales { get; set; } = new HashSet<Seles>();


    }
}
