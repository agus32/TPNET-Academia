using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CursoDAL
    {
        private readonly AcademiaContext _context;

        public CursoDAL()
        {
            _context = new AcademiaContext();
        }

        public List<Curso> GetAllCursos()
        {
            return _context.Cursos.ToList();
        }

        public void AgregarCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public void ModificarCurso(int IdCurso, int IdMateria, int IdComision, int AnioCalendario, int Cupo)
        {
            var curso = _context.Cursos.Find(IdCurso);
            if (curso != null)
            {
                curso.IdMateria = IdMateria;
                curso.IdComision = IdComision;
                curso.AnioCalendario = AnioCalendario;

                _context.Update(curso);
                _context.SaveChanges();
            }
        }

        public void BorrarCurso(int IdCurso)
        {
            var curso = _context.Cursos.Find(IdCurso);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
        }
    }
}
