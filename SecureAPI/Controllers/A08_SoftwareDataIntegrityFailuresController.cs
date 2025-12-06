using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A08_SoftwareDataIntegrityFailuresController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Validate JSON schema / allowlist fields in production
            if (request == null || string.IsNullOrWhiteSpace(request.Input)) return BadRequest();
            return Ok(new { issue = "Software & Data Integrity Failures", handled = "Validate signatures and restrict deserialization" });
        }

        
    }
}
