using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class API5_BrokenFunctionLevelAuthController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            return Ok(new { issue = "Broken Function Level Auth", handled = "Function-level RBAC enforced" });
        }
    }
}
