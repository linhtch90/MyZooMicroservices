using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LionService.Controller;

[Route("api/lion/basic")]
[ApiController]
public class BasicActivityController: ControllerBase
{
    [HttpGet("info1")]
    public IActionResult GetInfo1()
    {
        return Ok("This is Lion service - info1 route.");
    }
}