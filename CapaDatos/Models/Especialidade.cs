using System;
using System.Collections.Generic;

namespace CapaDatos.Models;

public partial class Especialidade
{
    public int IdEspecialidad { get; set; }

    public string? DescEspecialidad { get; set; }

    public virtual ICollection<Plane> Planes { get; set; } = new List<Plane>();
}
