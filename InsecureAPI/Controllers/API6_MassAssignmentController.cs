using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API6_MassAssignmentController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] dynamic dto)
        {
            // Vulnerável: aplica tudo do payload diretamente no modelo
            return Ok(new { issue = "API6 Mass Assignment (VULNERABLE)", payload = dto });
        }
    }
}
