namespace DemoCepRest.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoCepRest.Services;
using DemoCepRest.Models;
using DemoCepRest.DTOs;
using Microsoft.AspNetCore.Cors;

[ApiController]
[Route("api/v1/cep")]
[EnableCors("PermiteTudo")]
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

    //POST .../api/v1/cep
    [HttpPost]
    public ActionResult<CepDTO> Post(CepDTO cepDto)
    {
        CepModel? cepAtual = _cepRepository.ConsultarPorCodigoCep(cepDto.Cep);
        if (cepAtual != null) {
            //Mensagem de falha
            return Problem("Cep já existe na base de dados");
        }
        CepModel cepNovo = _cepRepository.Cadastrar(CepModel.ParaModel(cepDto));
        return CreatedAtAction(nameof(GetPorCodigo), new {codigoCep = cepNovo.Cep}, CepModel.ParaDTO(cepNovo));
    }
}