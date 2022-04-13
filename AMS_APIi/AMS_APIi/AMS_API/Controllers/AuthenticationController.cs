using AMS_API.DataAccess;
using AMS_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("signin")]
        public JsonResult GetUser(User user)
        {
            var connectionString = @"server=DESKTOP-EP55SB8\SQLEXPRESS;database=Ams_DB;trusted_connection=true";
            var userDA = new UserDataAccess(connectionString);
            var userResult = userDA.GetUser(user);
            if (userResult != null)
            {
                var key = "121h1wjhkusjk2sk2bkskj1bksk1jnskj1dbskw";
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes(key);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, userResult.FirstName)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                userResult.Token = tokenHandler.WriteToken(token);
                return new JsonResult(userResult);
            }

            return new JsonResult("User creadential is not correct !!");
        }
    }
}
