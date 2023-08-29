namespace DemoLojinha.Services;

using DemoLojinha.Models;

public interface IClientesRepository
{
    Task<Cliente?> ConsultarPorIdAsync(int id);
}