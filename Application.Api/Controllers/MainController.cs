using API_REST_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_MVC.Controllers;

[ApiController]
[Route("main")]
public class MainController : ControllerBase
{
    private readonly ILogger<MainController> _logger;
    private readonly UtilisateursService _utilisateursService;

    

    public MainController(ILogger<MainController> logger, UtilisateursService utilisateursService)
    {
        _logger = logger;
        _utilisateursService = utilisateursService;
    }

    [HttpGet]
    [Route("utilisateurs/get")]
    public IActionResult Get()
    {
        return this._utilisateursService.GetUtilisateurs();
    }

    [HttpPost]
    [Route("utilisateurs/add")]
    public string Post(string valeur)
    {
        return valeur.ToUpper();
    }
}

