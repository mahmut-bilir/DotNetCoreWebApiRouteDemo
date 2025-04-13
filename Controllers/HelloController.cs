using Microsoft.AspNetCore.Mvc;
namespace DotNetCoreWebApiRouteDemo.HelloController
{
  [ApiController]
  [Route("api/greetings")]
  public class HelloController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello, World!");
    }

    [HttpGet("sayhi")]
    public IActionResult SayHi()
    {
      return Ok("Hi there!");
    }
  }
}