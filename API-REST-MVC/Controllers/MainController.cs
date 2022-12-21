using Microsoft.AspNetCore.Mvc;

namespace API_REST_MVC.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : ControllerBase
{
    private readonly ILogger<MainController> _logger;

    

    public MainController(ILogger<MainController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "get")]
    public string Get()
    {
        return "ça marche";
    }

    [HttpPost]
    public string Post(string valeur)
    {
        return valeur.ToUpper();
    }
}

