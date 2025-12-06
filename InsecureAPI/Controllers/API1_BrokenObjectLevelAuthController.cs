using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API1_BrokenObjectLevelAuthController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo([FromQuery] string objectId)
        {
            // Vulnerável: retorna objeto sem checar proprietário
            return Ok(new { issue = "API1 BOLA (VULNERABLE)", objectId, owner = "unknown" });
        }
    }
}
