using Microsoft.AspNetCore.Mvc;
using SecureAPI.Controllers.DTOS;
using System.Security.Cryptography;
using System.Text;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class A02_CryptographicFailuresController : ControllerBase
    {
        [HttpPost("demo")]
        public IActionResult Demo([FromBody] DemoRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Input)) return BadRequest("Missing input");
            // Hash the input demonstrating correct cryptographic storage approach (simplified)
            using var sha = SHA256.Create();
            var hash = Convert.ToHexString(sha.ComputeHash(Encoding.UTF8.GetBytes(request.Input)));
            return Ok(new { issue = "Cryptographic Failures", handled = "SHA256 hashed (demo)", hash = hash });
        }

        
    }
}
