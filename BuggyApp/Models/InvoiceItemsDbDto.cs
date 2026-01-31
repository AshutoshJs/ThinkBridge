namespace BuggyApp.Models
{
    public class InvoiceItemsDbDto
    {
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
