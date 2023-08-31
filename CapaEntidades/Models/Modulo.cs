using System;
using System.Collections.Generic;

namespace CapaEntidades.Models;

public partial class Modulo
{
    public int IdModulo { get; set; }

    public string DescModulo { get; set; } = null!;

    public string Ejecuta { get; set; } = null!;

    public virtual ICollection<ModulosUsuario> ModulosUsuarios { get; set; } = new List<ModulosUsuario>();
}
