using Microsoft.AspNetCore.Mvc;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API9_ImproperInventoryManagementController : ControllerBase
    {
        [HttpGet("demo")]
        public IActionResult Demo()
        {
            // Vulnerável: não há inventário de APIs/rotas
            return Ok(new { issue = "API9 Improper Inventory (VULNERABLE)" });
        }
    }
}
