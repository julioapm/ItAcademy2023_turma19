namespace DemoLojinha.Services;

using Microsoft.EntityFrameworkCore;
using DemoLojinha.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ProdutosRepositoryEF : IProdutosRepository
{
    private readonly LojinhaContext _context;

    public ProdutosRepositoryEF(LojinhaContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> ConsultarTodosAsync()
    {
        return await _context.Produtos.OrderBy(p => p.Nome).ToListAsync();
    }
    
}