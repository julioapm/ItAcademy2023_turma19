namespace DemoLojinha.Services;

using DemoLojinha.Models;

public interface IPedidosRepository
{
    Task<Pedido?> ConsultarPorIdAsync(int id);
    Task<Pedido> AdicionarAsync(Pedido pedido);
}