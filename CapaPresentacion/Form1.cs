
using CapaDatos.Models;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly UsuarioBLL _usuarioBLL;
        public Form1()
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
    }
}