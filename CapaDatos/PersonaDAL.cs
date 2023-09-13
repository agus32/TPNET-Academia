using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PersonaDAL
    {
        private readonly AcademiaContext _context;
        public PersonaDAL()
        {
            _context = new AcademiaContext();
        }

        public List<Persona> GetAllPersona()
        {
            return _context.Personas.ToList();
        }

        public List<Plane> GetAllPlanes()
        {
            return _context.Planes.ToList();
        }
        public void AgregaPersona(Persona persona)
        {
            _context.Personas.Add(persona);
            _context.SaveChanges();
        }

        public void ModificarPersona(int IdPersona, string NombrePersona, string Apellido, string Direccion,
            string Mail, string Telefono, DateTime FechaNac, int Legajo, int TipoPersona, int IdPlan)
        {
            var persona = _context.Personas.Find(IdPersona);
            if (persona != null)
            {
                persona.Nombre = NombrePersona;
                persona.Apellido = Apellido;
                persona.Direccion = Direccion;
                persona.Mail = Mail;
                persona.Telefono = Telefono;
                persona.FechaNac = FechaNac;
                persona.Legajo = Legajo;
                persona.TipoPersona = TipoPersona;
                persona.IdPlan = IdPlan;
                _context.Update(persona);
                _context.SaveChanges();
            }
        }

        public void BorrarPersona(int IdPersona)
        {
            var persona = _context.Personas.Find(IdPersona);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                _context.SaveChanges();
            }
        }

    }
}
