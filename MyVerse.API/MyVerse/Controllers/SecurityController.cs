using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyVerse.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVerse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private IConfiguration _config;
        public SecurityController(IConfiguration Configuration)
        {
            _config = Configuration;
        }

        /// <summary>
        /// Authentication to have admin access
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(string user, string password)
        {
            User loginDetails = new User();
            loginDetails.NameUser = user;
            loginDetails.Password = password;
            bool result = UserValidate(loginDetails);
            if (result)
            {
                var tokenString = CreateTokenJWT();
                return Ok(
                    new
                    {
                        token = tokenString
                    }
                );
            }
            else
            {
                return Unauthorized();
            }
        }

        /// <summary>
        /// Create Token temporary to access
        /// </summary>
        /// <returns></returns>
        private string CreateTokenJWT()
        {
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(30);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer, audience: audience, expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }

        /// <summary>
        /// Validates if username and password are correct
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns></returns>
        private bool UserValidate(User loginDetails)
        {
            if(loginDetails.NameUser == "Admin" && loginDetails.Password == "Teste123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
