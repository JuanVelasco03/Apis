using Microsoft.AspNetCore.Mvc;
using webapi;


namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HelloWorldController: ControllerBase
{
  IHelloWorldService helloWorldService;

  TareasContext dbcontext;


   public HelloWorldController(IHelloWorldService helloWorld, TareasContext db)
  {
    helloWorldService = helloWorld;
    dbcontext = db;
  }

[HttpGet]
  public IActionResult Get()
  {
    return Ok(helloWorldService.GetHelloWorld());
  }

  [HttpGet]
  [Route("createdb")]

  public IActionResult CreateDataBase()
  {
    dbcontext.Database.EnsureCreated();
    return Ok();
  }
}