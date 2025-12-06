using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A09_SecurityLoggingMonitoringController : ControllerBase
    {
        private readonly ILogger<A09_SecurityLoggingMonitoringController> _logger;
        public A09_SecurityLoggingMonitoringController(ILogger<A09_SecurityLoggingMonitoringController> logger) => _logger = logger;

        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            _logger.LogInformation("A09 demo called by {user}", User.Identity?.Name ?? "anonymous");
            return Ok(new { issue = "Logging & Monitoring", handled = "Logs created for important events" });
        }

        
    }
}
