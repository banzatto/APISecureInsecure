using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class API6_MassAssignmentController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] UpdateDto dto)
        {
            // Use a DTO that only contains allowed fields
            return Ok(new { issue = "Mass Assignment", handled = "Use allowlist DTOs", updated = dto.Name });
        }

        
    }
}
