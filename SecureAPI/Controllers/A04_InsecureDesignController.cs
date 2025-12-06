using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A04_InsecureDesignController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            // Enforce business rules / validation
            if (request == null || !decimal.TryParse(request.Input, out var amount)) return BadRequest("Invalid amount");
            if (amount <= 0 || amount > 10000) return BadRequest("Amount out of allowed range");
            return Ok(new { issue = "Insecure Design", handled = "Business rules enforced", amount = amount });
        }

        
    }
}
