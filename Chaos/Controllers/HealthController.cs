using Microsoft.AspNetCore.Mvc;

namespace Chaos.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Status = "Healthy",
            CheckedAt = DateTime.UtcNow
        });
    }
}