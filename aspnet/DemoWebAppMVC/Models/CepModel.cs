namespace DemoWebAppMVC.Models;

public class CepModel
{
    public string Cep {get;set;} = null!;
    public string Estado {get;set;} = null!;
    public string Cidade {get;set;} = null!;
    public string Bairro {get;set;} = null!;
    public string Logradouro {get;set;} = null!;

    public static CepViewModel ParaViewModel(CepModel model)
    {
        return new CepViewModel {
            Cep = model.Cep,
            Estado = model.Estado,
            Cidade = model.Cidade,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
    }

    public static CepModel ParaModel(CepViewModel model)
    {
        return new CepModel {
            Cep = model.Cep,
            Estado = model.Estado,
            Cidade = model.Cidade,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
    }
}