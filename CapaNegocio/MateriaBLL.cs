using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos;

namespace CapaNegocio
{
    public class MateriaBLL
    {
        private readonly MateriaDAL _materiaDAL;

        public MateriaBLL()
        {
            _materiaDAL = new MateriaDAL();
        }

        public List<Materia> GetAllMaterias()
        {
            return _materiaDAL.GetAllMaterias();
        }

        public void AgregarMateria(string DescMateria, string HsSemanales, string HsTotales, string IdPlan)
        {

            Materia nuevaMateria = new Materia
            {
                DescMateria = DescMateria,
                HsSemanales = Convert.ToInt32(HsSemanales),
                HsTotales = Convert.ToInt32(HsTotales),
                IdPlan = Convert.ToInt32(IdPlan)
            };

            _materiaDAL.AgregarMateria(nuevaMateria);
        }

        public void ModificarMateria(string IdMateria, string DescMateria, string HsSemanales, string HsTotales, string IdPlan)
        {
            _materiaDAL.ModificarMateria(Convert.ToInt32(IdMateria), DescMateria, Convert.ToInt32(HsSemanales), Convert.ToInt32(HsTotales), Convert.ToInt32(IdPlan));

        }

        public void BorrarMateria(string IdMateria)
        {

            _materiaDAL.BorrarMateria(Convert.ToInt32(IdMateria));
        }
    }
}
