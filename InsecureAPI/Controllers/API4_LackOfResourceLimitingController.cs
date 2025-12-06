using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API4_LackOfResourceLimitingController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: sem limitação de taxa
            return Ok(new { issue = "API4 Lack of Rate Limiting (VULNERABLE)" });
        }
    }
}
