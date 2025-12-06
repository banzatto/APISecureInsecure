using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A08_SoftwareDataIntegrityFailuresController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] dynamic config)
        {
            // Vulnerável: aceita config sem validação/assinatura
            return Ok(new { issue = "Software/Data Integrity Failures (VULNERABLE)", config = config });
        }
    }
}
