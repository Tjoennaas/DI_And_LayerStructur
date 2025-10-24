


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Model;

namespace Controller;

[ApiController]
[Route("api/[controller]")]
public class InfoController : ControllerBase
{

   private readonly IOptionsSnapshot<ApplicationOption> _options;

    public InfoController(IOptionsSnapshot<ApplicationOption> options)
    {
        _options = options;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Name = _options.Value.Name

        });
    }
}




