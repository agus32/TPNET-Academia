using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            MateriaForm materiasform = new MateriaForm();
            this.Hide();
            materiasform.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm();
            this.Hide();
            usuarioForm.ShowDialog();
            this.Show();
        }
    }
}
