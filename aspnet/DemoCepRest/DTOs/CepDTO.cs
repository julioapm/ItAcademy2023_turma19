namespace DemoCepRest.DTOs;

using System.ComponentModel.DataAnnotations;

public class CepDTO
{
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Cep deve ter exatamente 8 dígitos")]
    public string Cep {get;set;} = null!;
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Estado deve ser uma sigla com exatamente duas letras maiúsculas")]
    public string Estado {get;set;} = null!;
    [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres")]
    public string Cidade {get;set;} = null!;
    [StringLength(30, ErrorMessage = "Bairro deve ter no máximo 30 caracteres")]
    public string Bairro {get;set;} = null!;
    [StringLength(70, ErrorMessage = "Logradouro deve ter no máximo 70 caracteres")]
    public string Logradouro {get;set;} = null!;
}