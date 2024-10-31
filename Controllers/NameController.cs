using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/name")]
    [ApiController]
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var result = new { Name = "Levi" };
            return Ok(result);
        }
    }
}
