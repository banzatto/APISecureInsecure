using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace InsecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API10_UnsafeConsumptionController : ControllerBase
    {
        [HttpGet("demo")]
        public async Task<IActionResult> Demo([FromQuery] string externalUrl)
        {
            // Vulnerável: consome URL externa sem validação
            using var client = new HttpClient();
            var result = await client.GetStringAsync(externalUrl);
            return Ok(new { issue = "API10 Unsafe Consumption (VULNERABLE)", snippet = result.Substring(0, Math.Min(200, result.Length)) });
        }
    }
}
