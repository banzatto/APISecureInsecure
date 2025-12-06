using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SecureAPI.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SecureAPI.Controllers.DTOS;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly MockUserStore _users;
        private readonly byte[] _key = Encoding.ASCII.GetBytes("VerySecretMockKey_For_Demo_ChangeMe!");

        public AuthController(MockUserStore users) => _users = users;

        [HttpPost("login")]
        public IActionResult Login([FromBody] DTOS.LoginRequest req)
        {
            var u = _users.Validate(req.Username, req.Password);
            if (u == null) return Unauthorized(new { message = "Invalid credentials" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, u.Username),
                    new Claim(ClaimTypes.Role, u.Role)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Ok(new { token = tokenHandler.WriteToken(token) });
        }
    }

    
}
