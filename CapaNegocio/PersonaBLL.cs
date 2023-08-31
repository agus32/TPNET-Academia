using CapaDatos;
using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PersonaBLL
    {
        private readonly PersonaDAL _personaDAL;
        public PersonaBLL()
        {
            _personaDAL = new PersonaDAL();
        }

        public List<Persona> GetAllPersona()
        {
            return _personaDAL.GetAllPersona();
        }

        public void AgregarPersona(string NombrePersona, string Apellido, string Direccion, string Mail,
            string Telefono, DateTime FechaNac, string Legajo, string TipoPersona, string IdPlan)
        {
            Persona persona = new Persona()
            {
                Nombre = NombrePersona,
                Apellido = Apellido,
                Direccion = Direccion,
                Mail = Mail,
                Telefono = Telefono,
                FechaNac = FechaNac,
                Legajo = Convert.ToInt32(Legajo),
                TipoPersona = ConvertTP(TipoPersona),
                IdPlan = Convert.ToInt32(IdPlan)

            };

            _personaDAL.AgregaPersona(persona);
        }

        private int ConvertTP(string TipoPersona)
        {
            if (TipoPersona == "Alumno")
            {
                return 1;
            }
            else
            {
                return 2;
            };
        }

        public void ModificarPersona(string IdPersona, string NombrePersona, string Apellido, string Direccion, string Mail,
            string Telefono, DateTime FechaNac, string Legajo, string TipoPersona, string IdPlan)
        {
            _personaDAL.ModificarPersona(Convert.ToInt32(IdPersona),
                                         NombrePersona,
                                         Apellido,
                                         Direccion,
                                         Mail,
                                         Telefono,
                                         FechaNac,
                                         Convert.ToInt32(Legajo),
                                         ConvertTP(TipoPersona),
                                         Convert.ToInt32(IdPlan));
        }



        public void BorrarPersona(string IdPersona)
        {
            _personaDAL.BorrarPersona(Convert.ToInt32(IdPersona));
        }

    }
}
