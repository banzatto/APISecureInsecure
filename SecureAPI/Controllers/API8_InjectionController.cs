using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API8_InjectionController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Show use of validated input and parameterization
            if (string.IsNullOrWhiteSpace(request.Input)) return BadRequest();
            return Ok(new { issue = "Injection (API)", handled = "Parameterize queries and validate input" });
        }

        
    }
}
