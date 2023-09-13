using CapaEntidades.Models;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CursoForm : Form
    {
        private readonly CursoBLL _cursoBLL;
        private bool Editar = false;
        string IdCurso;
        public CursoForm()
        {
            InitializeComponent();
            _cursoBLL = new CursoBLL();
        }

        private void CursoForm_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }
        private void MostrarCursos()
        {
            List<Curso> cursos = _cursoBLL.GetAllCursos();
            dataGridView1.DataSource = cursos;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Editar) // Agregar
            {
                try
                {

                    _cursoBLL.AgregarCurso(txtIdMateria.Text, txtIdComision.Text, txtAnioCalendario.Text, txtCupo.Text);
                    MessageBox.Show("Inserción completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCursos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Editar
            {
                try
                {

                    _cursoBLL.ModificarCurso(IdCurso, txtIdMateria.Text, txtIdComision.Text, txtAnioCalendario.Text, txtCupo.Text);
                    MessageBox.Show("Edición completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCursos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                IdCurso = dataGridView1.CurrentRow.Cells["IdCurso"].Value.ToString();
                txtIdMateria.Text = dataGridView1.CurrentRow.Cells["IdMateria"].Value?.ToString() ?? "";
                txtIdComision.Text = dataGridView1.CurrentRow.Cells["IdComision"].Value?.ToString() ?? "";
                txtAnioCalendario.Text = dataGridView1.CurrentRow.Cells["AnioCalendario"].Value?.ToString() ?? "";
                txtCupo.Text = dataGridView1.CurrentRow.Cells["Cupo"].Value?.ToString() ?? "";
            }
            else
                MessageBox.Show("Seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void limpiarForm()
        {
            txtIdMateria.Clear();
            txtIdComision.Clear();
            txtAnioCalendario.Clear();
            txtCupo.Clear();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                _cursoBLL.BorrarCurso(dataGridView1.CurrentRow.Cells["IdCurso"].Value.ToString());
                MessageBox.Show("Se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCursos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

