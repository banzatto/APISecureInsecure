using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API5_BrokenFunctionLevelAuthController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: qualquer usuário pode chamar função administrativa
            return Ok(new { issue = "API5 Broken Function Level Auth (VULNERABLE)" });
        }
    }
}
