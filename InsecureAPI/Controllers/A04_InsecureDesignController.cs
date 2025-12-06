using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A04_InsecureDesignController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] dynamic body)
        {
            // Vulnerável: sem validação de regras de negócio
            return Ok(new { issue = "Insecure Design (VULNERABLE)", body = body });
        }
    }
}
