using Microsoft.AspNetCore.Mvc;

namespace Api_Studies_Repo.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet]

    public ActionResult Hello()
    {
        return Ok("Yeni Api eklendi. Github action ile canlıya alındı.");
    }
}