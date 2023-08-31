
using CapaEntidades.Models;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion
{
    public partial class UsuarioForm : Form
    {
        private readonly UsuarioBLL _usuarioBLL;
        private bool Editar = false;
        string IdUsuario;
        public UsuarioForm()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            List<Usuario> usuarios = _usuarioBLL.GetAllUsuarios();
            dataGridView1.DataSource = usuarios;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Editar) // Agregar
            {
                try
                {

                    _usuarioBLL.AgregarUsuario(txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtIdPersona.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarUsuarios();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            else // Editar
            {
                try
                {

                    _usuarioBLL.ModificarUsuario(IdUsuario, txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtIdPersona.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarUsuarios();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                IdUsuario = dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString();
                txtNombreUsuario.Text = dataGridView1.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtClave.Text = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtIdPersona.Text = dataGridView1.CurrentRow.Cells["IdPersona"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void limpiarForm()
        {
            txtNombreUsuario.Clear();
            txtClave.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtIdPersona.Clear();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                _usuarioBLL.BorrarUsuario(dataGridView1.CurrentRow.Cells["IdUsuario"].Value.ToString());
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnMenu_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}