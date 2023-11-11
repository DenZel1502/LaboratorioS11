using Microsoft.EntityFrameworkCore;

namespace LaboratorioS11.Models
{
    //Representa DB y ENtity - Contiene clases y tablas
    public class DemoContext : DbContext
    {
        
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
