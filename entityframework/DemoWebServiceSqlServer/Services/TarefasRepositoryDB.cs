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

    public async Task AlterarAsync(Tarefa tarefa)
    {
        var model = await _context.Tarefas.FindAsync(tarefa.Id);
        model.Nome = tarefa.Nome;
        model.Descricao = tarefa.Descricao;
        model.Completa = tarefa.Completa;
        await _context.SaveChangesAsync();
    }

    public async Task<Tarefa> AdicionarAsync(Tarefa tarefa)
    {
        await _context.Tarefas.AddAsync(tarefa);
        await _context.SaveChangesAsync();
        return tarefa;
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