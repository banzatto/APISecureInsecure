using Microsoft.AspNetCore.Mvc;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API9_ImproperInventoryManagementController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo()
        {
            return Ok(new { issue = "Improper Inventory Management", handled = "Maintain API inventory & docs" });
        }
    }
}
