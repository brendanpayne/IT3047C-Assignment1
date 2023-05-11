using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week1.Models;

namespace Week1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet("Welcome/{name?}")]
        public string GetWelcomeMsg(string? name)
        {
            var result = $"Welcome to my API{(name?.Trim().Length > 0 ? $", {name}" : "")}!";

            return result;
        }

        [HttpPost("Message")]
        public string AddWelcomeMsg(Message message)
        {
            return message.Body;
        }
    }
}
