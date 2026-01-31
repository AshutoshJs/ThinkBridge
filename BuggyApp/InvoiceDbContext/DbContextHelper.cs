using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static BuggyApp.Controllers.InvoiceController;

namespace BuggyApp.InvoiceDbContext
{
    public class DbContextHelper : DbContext
    {
        public DbContextHelper(DbContextOptions options):base(options){}

        public DbSet<Item> item { get; set; }

    }
}
