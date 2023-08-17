namespace DemoWebAppMVC.Models;

using System.ComponentModel.DataAnnotations;

public class CepViewModel
{
    public string Cep {get;set;} = null!;
    public string Estado {get;set;} = null!;
    public string Cidade {get;set;} = null!;
    public string Bairro {get;set;} = null!;
    public string Logradouro {get;set;} = null!;
}