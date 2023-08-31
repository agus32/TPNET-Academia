using CapaEntidades.Models;
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

        public void ModificarUsuario(string IdUsuario, string NombreUsuario, string Clave, string Nombre, string Apellido, string Email, string IdPersona)
        {
            _usuarioDAL.ModificarUsuario(Convert.ToInt32(IdUsuario), NombreUsuario,  Clave,  Nombre,  Apellido,  Email, Convert.ToInt32(IdPersona));

        }

        public void BorrarUsuario(string IdUsuario)
        {
            
            _usuarioDAL.BorrarUsuario(Convert.ToInt32(IdUsuario));
        }
    }
}