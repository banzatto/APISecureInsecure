using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class A10_ServerSideRequestForgeryController : ControllerBase
    {
        [HttpGet("demo")]
        public async Task<IActionResult> Demo([FromQuery] string url)
        {
            // Vulnerável: faz fetch direto de URL fornecida pelo usuário (SSRF)
            using var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            return Ok(new { issue = "SSRF (VULNERABLE)", content = content.Substring(0, Math.Min(200, content.Length)) });
        }
    }
}
