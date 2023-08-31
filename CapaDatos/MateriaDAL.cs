using CapaEntidades.Models;


namespace CapaDatos
{
    public class MateriaDAL
    {
        private readonly AcademiaContext _context;

        public MateriaDAL()
        {
            _context = new AcademiaContext();
        }

        public List<Materia> GetAllMaterias()
        {
            return _context.Materias.ToList();
        }

        public void AgregarMateria(Materia materia)
        {
            _context.Materias.Add(materia);
            _context.SaveChanges();
        }

        public void ModificarMateria(int IdMateria, string DescMateria, int HsSemanales, int HsTotales, int IdPlan)
        {
            var materia = _context.Materias.Find(IdMateria);
            if (materia != null)
            {  
                materia.DescMateria = DescMateria;
                materia.HsSemanales = HsSemanales;
                materia.HsTotales = HsTotales;
                materia.IdPlan = IdPlan;
                
                _context.Update(materia);
                _context.SaveChanges();
            }
        }

        public void BorrarMateria(int IdMateria)
        {
            var materia = _context.Materias.Find(IdMateria);
            if (materia != null)
            {
                _context.Materias.Remove(materia);
                _context.SaveChanges();
            }
        }
    }
}
