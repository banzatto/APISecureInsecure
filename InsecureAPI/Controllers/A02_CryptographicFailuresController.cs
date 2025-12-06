using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A02_CryptographicFailuresController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo([FromQuery] string input)
        {
            // Vulnerável: retorna dados sensíveis em texto plano
            return Ok(new { issue = "Cryptographic Failures (VULNERABLE)", stored = input });
        }
    }
}
