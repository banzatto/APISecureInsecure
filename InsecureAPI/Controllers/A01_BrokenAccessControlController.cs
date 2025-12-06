using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A01_BrokenAccessControlController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo([FromQuery] string input)
        {
            // Vulnerável: sem autenticação e sem checagem de permissão
            return Ok(new { issue = "Broken Access Control (VULNERABLE)", input = input ?? "null" });
        }
    }
}
