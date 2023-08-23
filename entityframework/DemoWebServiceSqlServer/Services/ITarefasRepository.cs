namespace DemoWebServiceSqlServer.Services;

using DemoWebServiceSqlServer.Models;

public interface ITarefasRepository
{
    Task<IEnumerable<Tarefa>> ConsultarTodosAsync();
    Task<Tarefa?> ConsultarPorIdAsync(long id);
}