using Microsoft.AspNetCore.Mvc;
namespace DotNetCoreWebApiRouteDemo.HelloController  
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
      [HttpGet]
      public IActionResult Get()
      {
        return Ok("Hello, World!");
      }
    }
}