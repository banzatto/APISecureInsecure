using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API3_ExcessiveDataExposureController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: retorna dados completos do usuário
            return Ok(new { issue = "API3 Excessive Data Exposure (VULNERABLE)", id = 1, name = "Alice", ssn = "123-45-6789" });
        }
    }
}
