using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A06_VulnerableComponentsController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            // Demo: advise about package scanning and updates
            return Ok(new { issue = "Vulnerable Components", handled = "Use dependency scanning & update regularly" });
        }
    }
}
