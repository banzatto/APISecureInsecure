using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API2_BrokenAuthenticationController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] dynamic body)
        {
            // Vulnerável: autenticação fraca (simulada)
            return Ok(new { issue = "API2 Broken Authentication (VULNERABLE)" });
        }
    }
}
