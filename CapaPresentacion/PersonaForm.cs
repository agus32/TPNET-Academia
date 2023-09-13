using CapaEntidades.Models;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion
{
    public partial class PersonaForm : Form
    {
        private readonly PersonaBLL _personaBLL;
        private bool Editar = false;
        string IdPersona;

        public PersonaForm()
        {
            InitializeComponent();
            _personaBLL = new PersonaBLL();
        }

        private void frmAltaPersonas_Load_1(object sender, EventArgs e)
        {
            MostrarPersonas();
        }
        private void MostrarPersonas()
        {
            List<Persona> personas = _personaBLL.GetAllPersona();
            dgvPersonas_AltaPersonas.DataSource = personas;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Editar)
            {
                try
                {
                    _personaBLL.AgregarPersona(txtNombre_frmAltaPersona.Text, txtApellido_frmAltaPersona.Text,
                        txtDireccion_frmAltaPersona.Text, txtMail_frmAltaPersona.Text, txtTelefono_frmAltaPersona.Text,
                        dtpFechaNac_frmAltaPersona.Value, txtLegajo_frmAltaPersona.Text, cbTipoPersona_frmAltaPersona.SelectedItem.ToString(),
                        cbPlan_frmAltaPersona.SelectedItem.ToString());
                    MessageBox.Show("Inserción completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPersonas();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                try
                {
                    _personaBLL.ModificarPersona(IdPersona, txtNombre_frmAltaPersona.Text, txtApellido_frmAltaPersona.Text,
                        txtDireccion_frmAltaPersona.Text, txtMail_frmAltaPersona.Text, txtTelefono_frmAltaPersona.Text,
                        dtpFechaNac_frmAltaPersona.Value, txtLegajo_frmAltaPersona.Text,
                        cbTipoPersona_frmAltaPersona.SelectedItem.ToString(), cbPlan_frmAltaPersona.SelectedItem.ToString());
                    MessageBox.Show("Edición completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPersonas();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarForm()
        {
            txtNombre_frmAltaPersona.Clear();
            txtApellido_frmAltaPersona.Clear();
            txtDireccion_frmAltaPersona.Clear();
            txtLegajo_frmAltaPersona.Clear();
            txtMail_frmAltaPersona.Clear();
            txtTelefono_frmAltaPersona.Clear();
            cbPlan_frmAltaPersona.ResetText();
            cbTipoPersona_frmAltaPersona.ResetText();
            dtpFechaNac_frmAltaPersona.ResetText();
        }

        private void btnModificar_frmAltaPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas_AltaPersonas.SelectedRows.Count > 0)
            {
                Editar = true;
                IdPersona = dgvPersonas_AltaPersonas.CurrentRow.Cells["IdPersona"].Value.ToString();
                txtNombre_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
                txtMail_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["Mail"].Value?.ToString() ?? "";
                object valorCelda = dgvPersonas_AltaPersonas.CurrentRow.Cells["FechaNac"].Value;
                DateTime? fecha = valorCelda as DateTime?;
                dtpFechaNac_frmAltaPersona.Value = fecha ?? DateTime.Now;
                cbTipoPersona_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["TipoPersona"].Value?.ToString() ?? "";
                cbPlan_frmAltaPersona.Text = dgvPersonas_AltaPersonas.CurrentRow.Cells["IdPlan"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_frmAltaPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas_AltaPersonas.SelectedRows.Count > 0)
            {

                _personaBLL.BorrarPersona(dgvPersonas_AltaPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
                MessageBox.Show("Se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarPersonas();
            }
            else
                MessageBox.Show("Seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
