namespace DemoLojinha.Dtos;

using DemoLojinha.Models;

public class ProdutoRespostaDTO
{
    public int Id {get;set;}
    public string Nome {get;set;} = null!;
    public string? Descricao {get;set;}
    public string PrecoUnitario {get;set;} = null!;

    public static ProdutoRespostaDTO DeModelParaDto(Produto model)
    {
        ProdutoRespostaDTO dto = new ProdutoRespostaDTO();
        dto.Id = model.Id;
        dto.Nome = model.Nome;
        dto.Descricao = model.Descricao;
        dto.PrecoUnitario = $"{model.PrecoUnitario/100M:C}";
        return dto;
    }
}