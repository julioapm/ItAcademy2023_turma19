namespace DemoWebServiceSqlServer.Services;

using DemoWebServiceSqlServer.Models;
using Microsoft.EntityFrameworkCore;

public class TarefasRepositoryDB : ITarefasRepository
{
    private readonly TarefaContext _context;

    public TarefasRepositoryDB(TarefaContext context)
    {
        _context = context;
    }

    public async Task<Tarefa?> ConsultarPorIdAsync(long id)
    {
        return await _context.Tarefas
                       .Where(t => t.Id == id)
                       .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Tarefa>> ConsultarTodosAsync()
    {
        return await _context.Tarefas
                             .OrderBy(t => t.Nome)
                             .ToListAsync();
    }
}