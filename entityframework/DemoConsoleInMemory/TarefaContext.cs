using Microsoft.EntityFrameworkCore;

public class TarefaContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("TarefasBD");
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }

    public DbSet<Tarefa> Tarefas {get; set;} = null!;
}