
using Microsoft.AspNetCore.Mvc;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        /// <summary>
        /// Get DAta for the Invoices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetData()
        {
            string result = null;
            if(result.Length > 0) // will throw NullReferenceException
            {
                return Ok(new { message = "Data fetched" });
            }
            return BadRequest("No data");
        }
    }
}
