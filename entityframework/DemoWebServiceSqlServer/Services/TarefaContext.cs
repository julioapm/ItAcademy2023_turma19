namespace DemoWebServiceSqlServer.Services;

using Microsoft.EntityFrameworkCore;
using DemoWebServiceSqlServer.Models;

public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas {get; set;} = null!;

    public TarefaContext()
    {
    }

    public TarefaContext(DbContextOptions<TarefaContext> opcoes)
        : base(opcoes)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tarefa>()
                    .Property(t => t.Nome)
                    .HasMaxLength(30);
    }
}