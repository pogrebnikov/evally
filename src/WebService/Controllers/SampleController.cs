using Microsoft.AspNetCore.Mvc;

namespace Evally.WebService.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "print(\"hello world!\")";
    }
}