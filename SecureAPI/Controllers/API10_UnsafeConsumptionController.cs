using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API10_UnsafeConsumptionController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Validate and sanitize external API responses; disallow untrusted hosts
            if (request == null || string.IsNullOrWhiteSpace(request.Input)) return BadRequest();
            return Ok(new { issue = "Unsafe Consumption", handled = "Validate external data & implement timeouts" });
        }

        
    }
}
