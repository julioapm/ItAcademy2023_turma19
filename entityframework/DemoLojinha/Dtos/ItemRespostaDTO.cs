namespace DemoLojinha.Dtos;

using DemoLojinha.Models;

public class ItemRespostaDTO
{
    public int IdProduto {get;set;}
    public string NomeProduto {get;set;} = null!;
    public string ValorUnitario {get;set;} = null!;
    public int Quantidade {get;set;}
    public string SubTotal {get;set;} = null!;

    public static ItemRespostaDTO DeModelParaDto(Item model)
    {
        var dto = new ItemRespostaDTO();
        dto.IdProduto = model.ProdutoId;
        dto.NomeProduto = model.Produto.Nome;
        dto.ValorUnitario = $"{model.Produto.PrecoUnitario/100M:C}";
        dto.Quantidade = model.Quantidade;
        dto.SubTotal = $"{model.Quantidade*model.Produto.PrecoUnitario/100M:C}";
        return dto;
    }
}