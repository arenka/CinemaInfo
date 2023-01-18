using CinemaInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationsController : ControllerBase
    {
        private static readonly Dictionary<string, string> Users = new()
        {
            {"demir@yahoo.com","12345" },
            {"demir@saglik.com","12345" },
            {"demir@sigorta.com","12345" },
        };

        [HttpGet(Name = "User")]
        public IActionResult UserAuthentication(string email, string password)
        {
            var user = Users.FirstOrDefault(x => x.Key == email && x.Value == password);
            if (user.Key != null)
            {
                User result = new()
                {
                    Email = user.Key,
                    Password = user.Value,
                    IsActive = true
                };
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
