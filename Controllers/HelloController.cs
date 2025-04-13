using Microsoft.AspNetCore.Mvc;
namespace DotNetCoreWebApiRouteDemo.HelloController
{
  [ApiController]
  [Route("[api/greetings]")]
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

    //    [HttpPost]
    // public IActionResult PostData([FromBody] string data) { }

    // [HttpPut]
    // public IActionResult PutData(int id, [FormBody] string data)
    // {

    // }

    // [HttpDelete("{id}")]
    // public IActionResult DeleteData(int id)
    // {

    // }
  }
}