using System;
using System.Collections.Generic;

namespace CapaEntidades.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public bool Habilitado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool CambiaClave { get; set; }

    public int IdPersona { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    public virtual ICollection<ModulosUsuario> ModulosUsuarios { get; set; } = new List<ModulosUsuario>();
}
