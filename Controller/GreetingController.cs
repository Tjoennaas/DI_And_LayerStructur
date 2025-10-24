


using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Services;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{

    private readonly IGreeting _service;

    public GreetingController(IGreeting service) => _service = service;


    [HttpGet]
    public ActionResult<string> Get()

=> Ok(_service.GetMessag());
    } 


   
