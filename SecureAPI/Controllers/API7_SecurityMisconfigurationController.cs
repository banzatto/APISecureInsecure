using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API7_SecurityMisconfigurationController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            return Ok(new { issue = "Security Misconfiguration (API)", handled = "Hardened defaults & minimized surface" });
        }
    }
}
