
using BuggyApp.InvoiceDbContext;
using Microsoft.AspNetCore.Mvc;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        /// <summary>
        /// Get Data for the Invoices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetData()
        {
            var result = IDbContextService.GetInvoicesData();
            var invoiceData = IDbContextService.GetInvoicesData();
            var invoiceItemData = IDbContextService.GetInvoiceItemData();
            if (invoiceData!= null) 
            {
                return Ok(invoiceData);
            }

            //if (result.Length > 0) // will throw NullReferenceException
            //{
            //    return Ok(new { message = "Data fetched" });
            //}
            return BadRequest("No data");
        }
    }
}
