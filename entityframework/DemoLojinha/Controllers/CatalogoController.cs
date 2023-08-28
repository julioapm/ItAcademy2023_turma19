namespace DemoLojinha.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoLojinha.Services;
using DemoLojinha.Models;
using DemoLojinha.Dtos;

[ApiController]
[Route("api/v1/[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly IProdutosRepository _produtosRepository;

    public CatalogoController(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    //GET .../api/v1/catalogo
    [HttpGet]
    public async Task<IEnumerable<ProdutoRespostaDTO>> GetTodos()
    {
        var produtos = await _produtosRepository.ConsultarTodosAsync();
        return produtos.Select(p => ProdutoRespostaDTO.DeModelParaDto(p));
    }
}