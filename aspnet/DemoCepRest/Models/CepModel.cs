using DemoCepRest.DTOs;

namespace DemoCepRest.Models;

public class CepModel
{
    public string Cep {get;set;} = null!;
    public string Estado {get;set;} = null!;
    public string Cidade {get;set;} = null!;
    public string Bairro {get;set;} = null!;
    public string Logradouro {get;set;} = null!;

    public static CepDTO ParaDTO(CepModel model)
    {
        return new CepDTO {
            Cep = model.Cep,
            Estado = model.Estado,
            Cidade = model.Cidade,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
    }
}