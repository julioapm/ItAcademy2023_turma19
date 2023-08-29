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
    private readonly IClientesRepository _clientesRepository;
    private readonly IProdutosRepository _produtosRepository;

    public PedidosController(IPedidosRepository pedidosRepository, IClientesRepository clientesRepository, IProdutosRepository produtosRepository)
    {
        _pedidosRepository = pedidosRepository;
        _clientesRepository = clientesRepository;
        _produtosRepository = produtosRepository;
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

    //POST .../api/v1/pedidos
    [HttpPost]
    public async Task<ActionResult<PedidoRespostaDTO>> PostCarrinhoCompra(CarrinhoRequisicaoDTO carrinho)
    {
        var cliente = await _clientesRepository.ConsultarPorIdAsync(carrinho.IdCliente.GetValueOrDefault());
        if (cliente == null)
        {
            return BadRequest();
        }
        if (carrinho.Itens.Count() == 0)
        {
            return BadRequest();
        }
        var pedido = new Pedido();
        pedido.DataEmissao = DateTime.Now;
        pedido.Cliente = cliente;
        pedido.Itens = new List<Item>();
        foreach(var item in carrinho.Itens)
        {
            var produto = await _produtosRepository.ConsultarPorIdAsync(item.IdProduto.GetValueOrDefault());
            if (produto == null)
            {
                return BadRequest();
            }
            var itemPedido = new Item {
                Produto = produto,
                Quantidade = item.Quantidade.GetValueOrDefault()
            };
            pedido.Itens.Add(itemPedido);
        }
        var novoPedido = await _pedidosRepository.AdicionarAsync(pedido);
        return CreatedAtAction(nameof(GetPorId), new {id = novoPedido.Id}, PedidoRespostaDTO.DeModelParaDto(novoPedido));
    }
}