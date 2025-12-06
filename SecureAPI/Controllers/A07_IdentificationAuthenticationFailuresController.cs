using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class A07_IdentificationAuthenticationFailuresController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            // Demonstrate that sensitive operations require Admin role
            return Ok(new { issue = "Identification & Auth Failures", handled = "MFA and RBAC recommended (demo enforces RBAC)" });
        }
    }
}
