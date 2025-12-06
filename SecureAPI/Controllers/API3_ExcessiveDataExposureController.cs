using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API3_ExcessiveDataExposureController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Return allowlisted fields only
            return Ok(new { issue = "Excessive Data Exposure", handled = "Return only necessary fields" });
        }

        
    }
}
