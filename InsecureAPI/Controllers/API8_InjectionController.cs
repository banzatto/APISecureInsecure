using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API8_InjectionController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo([FromQuery] string q)
        {
            var query = $"SELECT * FROM items WHERE q = '{q}'";
            return Ok(new { issue = "API8 Injection (VULNERABLE)", query = query });
        }
    }
}
