Console.WriteLine("Iniciando conexão com BD");
using (var context = new TarefaContext())
{
    /*
    Console.WriteLine("Inserindo dados");
    context.Tarefas.Add(new Tarefa{
        Nome = "Estudar .NET",
        Descricao = "Ler o material do Learn Microsoft",
        Completa = false
    });
    context.Tarefas.Add(new Tarefa{
        Nome = "Lavar a louça",
        Completa = true
    });
    context.SaveChanges();
    */
    /*
    Console.WriteLine("Consultando dados");
    var todasTarefas = context.Tarefas.ToList();
    todasTarefas.ForEach(t => Console.WriteLine($"Id={t.Id} Nome={t.Nome} Descricao={t.Descricao} Completa={t.Completa}"));
    */

    /*
    Console.WriteLine("Alterando dados");
    var umaTarefa = context.Tarefas.Find(1L);
    if (umaTarefa != null)
    {
        umaTarefa.Completa = true;
    }
    context.SaveChanges();
    */

    Console.WriteLine("Removendo dados");
    var umaTarefa = context.Tarefas.Find(2L);
    if (umaTarefa != null)
    {
        context.Tarefas.Remove(umaTarefa);
    }
    context.SaveChanges();
}