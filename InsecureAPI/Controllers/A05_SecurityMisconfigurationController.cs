using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A05_SecurityMisconfigurationController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: pode expor detalhes de configuração (simulado)
            return Ok(new { issue = "Security Misconfiguration (VULNERABLE)", details = "Config: DEBUG=true; ConnectionString=server=..." });
        }
    }
}
