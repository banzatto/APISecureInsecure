using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A06_VulnerableComponentsController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: não há verificação de dependências desatualizadas
            return Ok(new { issue = "Vulnerable Components (VULNERABLE)" });
        }
    }
}
