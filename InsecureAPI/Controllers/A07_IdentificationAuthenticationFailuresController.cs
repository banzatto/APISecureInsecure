using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A07_IdentificationAuthenticationFailuresController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] dynamic body)
        {
            // Vulnerável: autenticação fraca / nenhuma (simulado)
            if (body != null && body.username == "admin") return Ok("logged in as admin (no check)");
            return Ok("logged in (no checks)");
        }
    }
}
