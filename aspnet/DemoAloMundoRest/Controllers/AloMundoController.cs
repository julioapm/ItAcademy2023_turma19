using DemoAloMundoRest.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DemoAloMundoRest.Controllers;

[ApiController]
[Route("[controller]")]
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;

    public AloMundoController(ILogger<AloMundoController> logger)
    {
        _logger = logger;
    }

    //GET .../alomundo
    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET /alomundo");
        return "Alô, Mundo!";
    }

    //GET .../alomundo/julio
    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation("GET /alomundo/{nome}");
        return $"Alô, {nome}!";
    }

    //GET .../alomundo/query?nome=julio
    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation("GET /alomundo/query?nome=valor");
        return $"Alô, {nome}!";
    }

    //POST .../alomundo
    [HttpPost]
    public string Post([FromBody] string nome)
    {
        _logger.LogInformation("POST /alomundo");
        return $"Alô, {nome}!";
    }

    //POST .../alomundo/pessoa
    [HttpPost("pessoa")]
    public string Post(Pessoa umaPessoa)
    {
        _logger.LogInformation("POST /alomundo/pessoa");
        return $"Alô, {umaPessoa.Nome}!";
    }
}