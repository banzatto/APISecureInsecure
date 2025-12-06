using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A03_InjectionController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo([FromQuery] string input)
        {
            // Vulnerável: concatenação de queries (simulada)
            var query = $"SELECT * FROM Users WHERE name = '{input}'";
            return Ok(new { issue = "Injection (VULNERABLE)", query = query });
        }
    }
}
