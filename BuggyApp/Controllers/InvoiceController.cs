
using BuggyApp.InvoiceDbContext;
using BuggyApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            var result = IDbContextService.GetInvoicesData();
            var invoiceData = IDbContextService.GetInvoicesData();
            var invoiceItemData = IDbContextService.GetInvoiceItemData();
            List<Item> items = invoiceItemData.Select(x => new Item(x)).ToList();
            if (items != null)
            {
                return Ok(items);
            }
            //var invoiceData = IDbContextService.GetInvoicesData();
            //var invoiceItemData = IDbContextService.GetInvoiceItemData();
            //var preItems = invoiceItemData.Select(x => invoiceData.Where(y => x.InvoiceID == y.InvoiceID)).ToList();
            //List<Item> items = invoiceItemData.Select(x => new Item(x)).ToList();
            //if (items.Count == 0) // NullReferenceException
            //{
            //    return Ok(new { items });
            //}
            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
            public Item(){}

            public Item(InvoiceItemsDbDto data) 
            {
                this.name = data.Name;
                this.price = data.Price;   
            }
        }
    }
}
