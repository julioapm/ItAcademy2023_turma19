using DemoCepRest.Models;
using System.Collections.Concurrent;

namespace DemoCepRest.Services;

public class CepRepositoryMemory : ICepRepository
{
    private readonly ConcurrentDictionary<string, CepModel> dados =
        new ConcurrentDictionary<string, CepModel>();

    public CepRepositoryMemory()
    {
        dados.TryAdd("90619900", new CepModel{
            Cep = "90619900",
            Estado = "RS",
            Cidade = "Porto Alegre",
            Bairro = "Partenon",
            Logradouro = "Av. Ipiranga, 6681"
        });
        dados.TryAdd("01001000", new CepModel{
            Cep = "01001000",
            Estado = "SP",
            Cidade = "São Paulo",
            Bairro = "Sé",
            Logradouro = "Praça da Sé"
        });
    }

    public CepModel Cadastrar(CepModel cepModel)
    {
        throw new NotImplementedException();
    }

    public CepModel? ConsultarPorCodigoCep(string codigoCep)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CepModel> ConsultarTodos()
    {
        return dados.Values;
    }
}