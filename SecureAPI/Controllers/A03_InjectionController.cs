using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A03_InjectionController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            if (request == null || request.Input == null) return BadRequest();
            // Simulate parameterized query usage (no raw concatenation)
            // This demo returns the sanitized input
            var sanitized = request.Input.Replace("'", "''"); // simplistic example
            return Ok(new { issue = "Injection", handled = "Use parameterized queries", input = sanitized });
        }

        
    }
}
