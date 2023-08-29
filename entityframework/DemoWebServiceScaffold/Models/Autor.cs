using System;
using System.Collections.Generic;

namespace DemoWebServiceScaffold.Models;

public partial class Autor
{
    public int Id { get; set; }

    public string PrimeiroNome { get; set; } = null!;

    public string UltimoNome { get; set; } = null!;

    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
