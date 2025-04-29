using Microsoft.AspNetCore.Mvc;

namespace Project2_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Why do programmers prefer dark mode? Because light attracts bugs!";
    }
}
