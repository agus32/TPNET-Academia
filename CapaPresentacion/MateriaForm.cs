
using CapaEntidades.Models;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class MateriaForm : Form
    {
        private readonly MateriaBLL _materiaBLL;
        private bool Editar = false;
        string IdMateria;
        public MateriaForm()
        {
            InitializeComponent();
            _materiaBLL = new MateriaBLL();
        }

        private void MateriaForm_Load(object sender, EventArgs e)
        {
            MostrarMaterias();
        }
        private void MostrarMaterias()
        {
            List<Materia> materias = _materiaBLL.GetAllMaterias();
            dataGridView1.DataSource = materias;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Editar) // Agregar
            {
                try
                {

                    _materiaBLL.AgregarMateria(txtDescMateria.Text, txtHsSemanales.Text, txtHsTotales.Text, txtIdPlan.Text);
                    MessageBox.Show("Inserción completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMaterias();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Editar
            {
                try
                {

                    _materiaBLL.ModificarMateria(IdMateria, txtDescMateria.Text, txtHsSemanales.Text, txtHsTotales.Text, txtIdPlan.Text);
                    MessageBox.Show("Edición completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMaterias();
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
                IdMateria = dataGridView1.CurrentRow.Cells["IdMateria"].Value.ToString();
                txtDescMateria.Text = dataGridView1.CurrentRow.Cells["DescMateria"].Value?.ToString() ?? "";
                txtHsSemanales.Text = dataGridView1.CurrentRow.Cells["HsSemanales"].Value?.ToString() ?? "";
                txtHsTotales.Text = dataGridView1.CurrentRow.Cells["HsTotales"].Value?.ToString() ?? "";
                txtIdPlan.Text = dataGridView1.CurrentRow.Cells["IdPlan"].Value?.ToString() ?? "";
            }
            else
                MessageBox.Show("Seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void limpiarForm()
        {
            txtDescMateria.Clear();
            txtHsSemanales.Clear();
            txtHsTotales.Clear();
            txtIdPlan.Clear();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                _materiaBLL.BorrarMateria(dataGridView1.CurrentRow.Cells["IdMateria"].Value.ToString());
                MessageBox.Show("Se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMaterias();
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

