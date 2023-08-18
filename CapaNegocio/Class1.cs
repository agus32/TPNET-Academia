using CapaDatos.Models;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL;

        public UsuarioBLL()
        {
            _usuarioDAL = new UsuarioDAL(); 
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _usuarioDAL.GetAllUsuarios();
        }

        public void AgregarUsuario(string NombreUsuario,string Clave, string Nombre, string Apellido,string Email,string IdPersona)
        {

            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = NombreUsuario,
                Clave = Clave,
                Habilitado = false,
                Nombre = Nombre,
                Apellido = Apellido,
                Email = Email,
                CambiaClave = false,
                IdPersona = Convert.ToInt32(IdPersona)
            };   
                
            _usuarioDAL.AgregarUsuario(nuevoUsuario);
        }

        public void ModificarUsuario(Usuario usuario)
        {
            // Puedes realizar validaciones o lógica adicional antes de actualizar el usuario
            _usuarioDAL.ModificarUsuario(usuario);
        }

        public void BorrarUsuario(int id)
        {
            // Puedes realizar validaciones o lógica adicional antes de eliminar el usuario
            _usuarioDAL.BorrarUsuario(id);
        }
    }
}