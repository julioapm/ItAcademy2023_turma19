namespace DemoLojinha.Services;

using Microsoft.EntityFrameworkCore;
using DemoLojinha.Models;
using System.Threading.Tasks;

public class ClientesRepositoryEF : IClientesRepository
{
    private readonly LojinhaContext _context;

    public ClientesRepositoryEF(LojinhaContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> ConsultarPorIdAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }
}