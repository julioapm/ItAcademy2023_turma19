namespace DemoLojinha.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoLojinha.Services;
using DemoLojinha.Models;
using DemoLojinha.Dtos;

[ApiController]
[Route("api/v1/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IPedidosRepository _pedidosRepository;

    public PedidosController(IPedidosRepository pedidosRepository)
    {
        _pedidosRepository = pedidosRepository;
    }

    //GET .../api/v1/pedidos/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<PedidoRespostaDTO>> GetPorId(int id)
    {
        var pedido = await _pedidosRepository.ConsultarPorIdAsync(id);
        if (pedido == null) {
            return NotFound();
        }
        return PedidoRespostaDTO.DeModelParaDto(pedido);
    }
}