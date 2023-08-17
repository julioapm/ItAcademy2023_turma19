namespace DemoWebAppMVC.Services;

using DemoWebAppMVC.Models;

public interface ICepRepository
{
    IEnumerable<CepModel> ConsultarTodos();
    CepModel? ConsultarPorCodigoCep(string codigoCep);
    CepModel Cadastrar(CepModel cepModel);
}