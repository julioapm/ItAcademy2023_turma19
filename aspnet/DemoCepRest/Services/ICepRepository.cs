namespace DemoCepRest.Services;

using DemoCepRest.Models;

public interface ICepRepository
{
    IEnumerable<CepModel> ConsultarTodos();
    CepModel? ConsultarPorCodigoCep(string codigoCep);
    CepModel Cadastrar(CepModel cepModel);
}