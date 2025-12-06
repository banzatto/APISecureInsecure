using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A05_SecurityMisconfigurationController : ControllerBase
    {
        private readonly ILogger<A05_SecurityMisconfigurationController> _logger;
        public A05_SecurityMisconfigurationController(ILogger<A05_SecurityMisconfigurationController> logger) => _logger = logger;

        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            _logger.LogInformation("Demo called for security misconfiguration check");
            // Return safe error and no internal secrets
            return Ok(new { issue = "Security Misconfiguration", handled = "No secrets leaked in responses" });
        }

        
    }
}
