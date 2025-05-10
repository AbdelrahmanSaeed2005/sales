using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.models
{
    class Seles
    {
        [Key]
        public int selesId { get; set; }
        public DateTime data { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int StoreId { get; set; }
        public Stores Stores { get; set; }
    }
}
