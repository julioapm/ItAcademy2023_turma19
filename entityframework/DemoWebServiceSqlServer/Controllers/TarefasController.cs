namespace DemoWebServiceSqlServer.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoWebServiceSqlServer.Services;
using DemoWebServiceSqlServer.Models;
using DemoWebServiceSqlServer.Dtos;

[ApiController]
[Route("api/v1/[controller]")]
public class TarefasController : ControllerBase
{
    private readonly ITarefasRepository _repository;

    public TarefasController(ITarefasRepository repository)
    {
        _repository = repository;
    }

    //GET .../api/v1/tarefas
    [HttpGet]
    public async Task<IEnumerable<TarefaRespostaDto>> GetTodos()
    {
        var tarefas = await _repository.ConsultarTodosAsync();
        return tarefas.Select(t => TarefaRespostaDto.ParaDto(t));
    }

    //GET .../api/v1/tarefas/{id}
    [HttpGet("{id:long}")]
    public async Task<ActionResult<TarefaRespostaDto>> GetPorId(long id)
    {
        var tarefa = await _repository.ConsultarPorIdAsync(id);
        if (tarefa == null)
        {
            return NotFound();
        }
        return TarefaRespostaDto.ParaDto(tarefa);
    }

    //POST .../api/v1/tarefas
    [HttpPost]
    public async Task<ActionResult<TarefaRespostaDto>> PostNovaTarefa(TarefaRequisicaoDto dto)
    {
        var model = new Tarefa();
        model.Nome = dto.Nome!;
        model.Descricao = dto.Descricao;
        model.Completa = false;
        var novaTarefa = await _repository.AdicionarAsync(model);
        return CreatedAtAction(nameof(GetPorId), new {id = novaTarefa.Id}, TarefaRespostaDto.ParaDto(novaTarefa));
    }

    
}