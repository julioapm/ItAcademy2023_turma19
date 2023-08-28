namespace DemoLojinha.Services;

using DemoLojinha.Models;

public interface IProdutosRepository
{
    Task<IEnumerable<Produto>> ConsultarTodosAsync();
}