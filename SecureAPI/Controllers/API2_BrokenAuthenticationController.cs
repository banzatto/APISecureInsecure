using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API2_BrokenAuthenticationController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            // Enforce multi-factor, token expiry etc. (demo)
            return Ok(new { issue = "Broken Authentication", handled = "JWT + token expiry + secure storage" });
        }
    }
}
