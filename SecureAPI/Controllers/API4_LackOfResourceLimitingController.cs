using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API4_LackOfResourceLimitingController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            // Demo: respond with rate-limit header suggestion
            Response.Headers.Add("X-RateLimit-Limit", "100");
            return Ok(new { issue = "Lack of Resource Limiting", handled = "Apply rate limits and quotas" });
        }
    }
}
