using Microsoft.EntityFrameworkCore;
using Sales.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sales.dataAccess
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> CustomerS { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seles> Seles { get; set; }
        public DbSet<Stores> Stores { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = Sales; Integrated Security = True; TrustServerCertificate = True");
        }
    }
}
