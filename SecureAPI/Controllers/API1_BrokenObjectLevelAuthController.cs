using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class API1_BrokenObjectLevelAuthController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Ensure object-level authorization: demo requires admin
            return Ok(new { issue = "BOLA", handled = "Object-level checks (owner/admin)" });
        }

        
    }
}
