namespace DemoWebServiceSqlServer.Dtos;

using DemoWebServiceSqlServer.Models;

public class TarefaRespostaDto
{
    public long Id {get; set;}
    public string Nome {get; set;} = null!;
    public string? Descricao {get; set;}
    public bool Completa {get; set;}

    public static TarefaRespostaDto ParaDto(Tarefa model)
    {
        return new TarefaRespostaDto{
            Id = model.Id,
            Nome = model.Nome,
            Descricao = model.Descricao,
            Completa = model.Completa
        };
    }
}