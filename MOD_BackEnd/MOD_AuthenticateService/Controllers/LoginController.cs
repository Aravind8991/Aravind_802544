using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using MOD_AuthenticateService.Repositories;
using MOD_AuthenticateService.Models;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace MOD_AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IloginRepository _repository;

        public LoginController(IloginRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Login


        [HttpGet]
        [Route("Validate/{id}/{password}")]
        public Token Get(string id, string password)
        {
  
                if (_repository.UserLogin(id, password))
                {
                    return new Token() { message = "User", token = GetToken() };
                }
                else if (_repository.MentorLogin(id, password))
                {
                    return new Token() { message = "Mentor", token = GetToken() };

                }
                else if (id == "Admin" && password == "Admin")
                {
                    return new Token() { message = "Admin", token = GetToken() };

                }
                else
                {
                    return new Token() { message = "Invalid User", token = "" };

                }
            
           
        }
        public string GetToken()
        {
       
            var _config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer,
        audience: audience,
        expires: DateTime.Now.AddMinutes(120),
        signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
            }
         
    }
}