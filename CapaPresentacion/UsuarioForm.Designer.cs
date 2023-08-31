namespace CapaPresentacion
{
    partial class UsuarioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnviar = new Button();
            dataGridView1 = new DataGridView();
            txtNombreUsuario = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtIdPersona = new TextBox();
            lblNombreUsuario = new Label();
            lblClave = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblIdPersona = new Label();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(998, 229);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(240, 44);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(880, 454);
            dataGridView1.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(1055, 53);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(183, 23);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(1055, 84);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(183, 23);
            txtClave.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1055, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1055, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1055, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(1055, 200);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(183, 23);
            txtIdPersona.TabIndex = 9;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(955, 56);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(1013, 87);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 12;
            lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(998, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(998, 145);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(1013, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblIdPersona
            // 
            lblIdPersona.AutoSize = true;
            lblIdPersona.Location = new Point(990, 203);
            lblIdPersona.Name = "lblIdPersona";
            lblIdPersona.Size = new Size(59, 15);
            lblIdPersona.TabIndex = 16;
            lblIdPersona.Text = "IdPersona";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 489);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(107, 489);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(1075, 489);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(219, 60);
            btnMenu.TabIndex = 19;
            btnMenu.Text = "Volver al Menu Principal";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 561);
            Controls.Add(btnMenu);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(lblIdPersona);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblClave);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtIdPersona);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(txtNombreUsuario);
            Controls.Add(dataGridView1);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private DataGridView dataGridView1;
        private TextBox txtNombreUsuario;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtIdPersona;
        private Label lblNombreUsuario;
        private Label lblClave;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblIdPersona;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnMenu;
    }
}