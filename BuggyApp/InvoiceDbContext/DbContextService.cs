using BuggyApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static BuggyApp.Controllers.InvoiceController;

namespace BuggyApp.InvoiceDbContext
{
    public class DbContextService : DbContext
    {
        public DbContextService(DbContextOptions options):base(options){}

        public DbSet<Item> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
                 InvoiceID INT PRIMARY KEY,
     CustomerName VARCHAR(100)
                 */
            //modelBuilder.Entity<Item>(entity =>
            //{
            //    entity.HasKey(e => e.InvoiceID);
                


            //});

            //modelBuilder.Entity<Item>(entity =>
            //{
            //    entity.Property(e => e.CustomerName);
               
            //});

        }
        //public List<InvoiceItemsDbDto> GetInvoiceItemData()
        //{
        //    //return new List<InvoiceItems>().Add(new InvoiceItems() { ItemID=1, InvoiceID=1, Name = "Widget A", Price=19.99 });
        //    var invoiceItems = new List<InvoiceItemsDbDto>();
        //    invoiceItems.Add(new InvoiceItemsDbDto() { ItemID = 1, InvoiceID = 1, Name = "Widget A", Price = 19.99 });
        //    return invoiceItems;
        //}

        //public List<InvoicesDbDto> GetInvoicesData()
        //{
        //    var invoiceItems = new List<InvoicesDbDto>();
        //    invoiceItems.Add(new InvoicesDbDto() { InvoiceID = 1, CustomerName = "John Doe" });
        //    return invoiceItems;
        //}
    }
}
