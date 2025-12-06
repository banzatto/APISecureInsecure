using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API7_SecurityMisconfigurationController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            return Ok(new { issue = "API7 Security Misconfiguration (VULNERABLE)" });
        }
    }
}
