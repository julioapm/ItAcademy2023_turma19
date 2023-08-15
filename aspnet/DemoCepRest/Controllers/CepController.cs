namespace DemoCepRest.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoCepRest.Services;
using DemoCepRest.Models;
using DemoCepRest.DTOs;

[ApiController]
[Route("api/v1/cep")]
public class CepController : ControllerBase
{
    private readonly ILogger<CepController> _logger;
    private readonly ICepRepository _cepRepository;

    public CepController(ILogger<CepController> logger, ICepRepository cepRepository)
    {
        _logger = logger;
        _cepRepository = cepRepository;
    }

    //GET .../api/v1/cep
    [HttpGet]
    public IEnumerable<CepDTO> GetTodos()
    {
        return _cepRepository.ConsultarTodos()
               .OrderBy(c => c.Cidade)
               .Select(c => CepModel.ParaDTO(c))
               .ToList();
    }

    //GET .../api/v1/cep/90619900
    [HttpGet("{codigocep:regex(^\\d{{8}}$)}")]
    public ActionResult<CepDTO> GetPorCodigo(string codigocep)
    {
        var cep = _cepRepository.ConsultarPorCodigoCep(codigocep);
        if (cep == null)
        {
            return NotFound();
        }
        return CepModel.ParaDTO(cep);
    }
}