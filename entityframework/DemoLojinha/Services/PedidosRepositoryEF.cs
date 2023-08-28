namespace DemoLojinha.Services;

using Microsoft.EntityFrameworkCore;
using DemoLojinha.Models;
using System.Threading.Tasks;

public class PedidosRepositoryEF : IPedidosRepository
{
    private readonly LojinhaContext _context;

    public PedidosRepositoryEF(LojinhaContext context)
    {
        _context = context;
    }

    public async Task<Pedido?> ConsultarPorIdAsync(int id)
    {
        var pedido = await _context.Pedidos
                    .Where(p => p.Id == id)
                    .Include(p => p.Cliente)
                    .Include(p => p.Itens)
                    .FirstOrDefaultAsync();
        return pedido;
    }
}