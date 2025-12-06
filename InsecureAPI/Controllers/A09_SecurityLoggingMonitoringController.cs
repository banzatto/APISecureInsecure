using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A09_SecurityLoggingMonitoringController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: sem logs auditáveis
            return Ok(new { issue = "Logging & Monitoring Failures (VULNERABLE)", logged = false });
        }
    }
}
