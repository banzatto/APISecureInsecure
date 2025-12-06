using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A10_ServerSideRequestForgeryController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Input)) return BadRequest();
            // Validate allowed hosts - simplistic check
            if (!request.Input.StartsWith("https://api.trusted.local")) return BadRequest("External URLs not allowed");
            return Ok(new { issue = "SSRF", handled = "Allowed hosts validated" });
        }

        
    }
}
