using System;
using System.Collections.Generic;

namespace DemoWebServiceScaffold.Models;

public partial class Livro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    public virtual ICollection<Autor> Autores { get; set; } = new List<Autor>();
}
