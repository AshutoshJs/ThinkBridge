using BuggyApp.Models;

namespace BuggyApp.InvoiceDbContext
{
    public static class IDbContextService
    {
        public static List<InvoiceItemsDbDto> GetInvoiceItemData()
        {
            //return new List<InvoiceItems>().Add(new InvoiceItems() { ItemID=1, InvoiceID=1, Name = "Widget A", Price=19.99 });
            var invoiceItems = new List<InvoiceItemsDbDto>();
            invoiceItems.Add(new InvoiceItemsDbDto() { ItemID = 1, InvoiceID = 1, Name = "Widget A", Price = 19.99 });
            return invoiceItems;
        }

        public static List<InvoicesDbDto> GetInvoicesData()
        {
            var invoiceItems = new List<InvoicesDbDto>();
            invoiceItems.Add(new InvoicesDbDto() { InvoiceID = 1, CustomerName = "John Doe" });
            return invoiceItems;
        }
    }
}
