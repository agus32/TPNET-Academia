using CapaEntidades.Models;
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

        public List<Plane> GetAllPlanes()
        {
            return _materiaDAL.GetAllPlanes();
        }

        public void AgregarMateria(string DescMateria, string HsSemanales, string HsTotales, int IdPlan)
        {

            Materia nuevaMateria = new Materia
            {
                DescMateria = DescMateria,
                HsSemanales = Convert.ToInt32(HsSemanales),
                HsTotales = Convert.ToInt32(HsTotales),
                IdPlan = IdPlan
            };

            _materiaDAL.AgregarMateria(nuevaMateria);
        }

        public void ModificarMateria(string IdMateria, string DescMateria, string HsSemanales, string HsTotales, int IdPlan)
        {
            _materiaDAL.ModificarMateria(Convert.ToInt32(IdMateria), DescMateria, Convert.ToInt32(HsSemanales), Convert.ToInt32(HsTotales),IdPlan);

        }

        public void BorrarMateria(string IdMateria)
        {

            _materiaDAL.BorrarMateria(Convert.ToInt32(IdMateria));
        }
    }
}
