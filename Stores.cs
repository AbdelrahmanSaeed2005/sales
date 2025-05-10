using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.models
{
    class Stores
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public ICollection<Seles> Sales { get; set; } = new HashSet<Seles>();
    }
}
