using System;
using System.Collections.Generic;

namespace CapaEntidades.Models;

public partial class ModulosUsuario
{
    public int IdModuloUsuario { get; set; }

    public int IdModulo { get; set; }

    public int IdUsuario { get; set; }

    public bool Alta { get; set; }

    public bool Baja { get; set; }

    public bool Modificacion { get; set; }

    public bool Consulta { get; set; }

    public virtual Modulo IdModuloNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
