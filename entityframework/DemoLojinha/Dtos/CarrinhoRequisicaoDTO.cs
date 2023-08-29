namespace DemoLojinha.Dtos;

using System.ComponentModel.DataAnnotations;

public class CarrinhoRequisicaoDTO
{
    [Required(ErrorMessage = "IdCliente é obrigatório")]
    public int? IdCliente {get;set;}
    [Required(ErrorMessage = "Itens é obrigatório")]
    public IEnumerable<ItemCarrinhoRequisicaoDTO> Itens {get;set;} = null!;
}

public class ItemCarrinhoRequisicaoDTO
{
    [Required(ErrorMessage = "IdProduto é obrigatório")]
    public int? IdProduto {get;set;}
    [Required(ErrorMessage = "Quantidade é obrigatório")]
    [Range(1,10, ErrorMessage = "No mínimo 1 e no máximo 10 unidades do produto")]
    public int? Quantidade {get;set;}
}