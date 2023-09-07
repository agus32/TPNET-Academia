using CapaDatos;
using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CursoBLL
    {
        private readonly CursoDAL _cursoDAL;

        public CursoBLL()
        {
            _cursoDAL = new CursoDAL();
        }

        public List<Curso> GetAllCursos()
        {
            return _cursoDAL.GetAllCursos();
        }

        public void AgregarCurso(string IdMateria, string IdComision, string AnioCalendario, string Cupo)
        {

            Curso nuevoCurso = new Curso
            {
                IdMateria = Convert.ToInt32(IdMateria),
                IdComision = Convert.ToInt32(IdComision),
                AnioCalendario = Convert.ToInt32(AnioCalendario),
                Cupo = Convert.ToInt32(Cupo)
            };

            _cursoDAL.AgregarCurso(nuevoCurso);
        }

        public void ModificarCurso(string IdCurso, string IdMateria, string IdComision, string AnioCalendario, string Cupo)
        {
            _cursoDAL.ModificarCurso(Convert.ToInt32(IdCurso),Convert.ToInt32(IdMateria), Convert.ToInt32(IdComision), Convert.ToInt32(AnioCalendario), Convert.ToInt32(Cupo));

        }

        public void BorrarCurso(string IdCurso)
        {

            _cursoDAL.BorrarCurso(Convert.ToInt32(IdCurso));
        }
    }
}
