using BearService.Model;
using Microsoft.AspNetCore.Mvc;

namespace BearService.Controller;

[Route("api/bear/basic")]
[ApiController]
public class BasicActivityController: ControllerBase
{
    [HttpGet("info1")]
    public IActionResult GetInfo1()
    {
        return Ok(new BasicResponseDto()
        {
            Name = "Luna the bear",
            Description = "This is not a panda",
        });
    }
}