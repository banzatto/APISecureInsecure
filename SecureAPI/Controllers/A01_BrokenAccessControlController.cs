using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class A01_BrokenAccessControlController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Input)) return BadRequest("Missing input");
            // Only Admin role allowed by attribute
            return Ok(new { issue = "Broken Access Control", handled = "RBAC enforced", input = request.Input });
        }

        
    }
}
