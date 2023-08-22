using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos
{
    public class UsuarioDAL
    {
        private readonly AcademiaContext _context;

        public UsuarioDAL()
        {
            _context = new AcademiaContext();
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void ModificarUsuario(int IdUsuario, string NombreUsuario, string Clave, string Nombre, string Apellido, string Email, int IdPersona)
        {
            var usuario = _context.Usuarios.Find(IdUsuario);
            if (usuario != null)
            {
                usuario.NombreUsuario = NombreUsuario;
                usuario.Clave = Clave;
                usuario.Nombre = Nombre;
                usuario.Apellido = Apellido;
                usuario.Email = Email;
                usuario.IdPersona = IdPersona;               
                _context.Update(usuario);
                _context.SaveChanges();
            }
        }

        public void BorrarUsuario(int IdUsuario)
        {
            var usuario = _context.Usuarios.Find(IdUsuario);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}