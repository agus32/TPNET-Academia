namespace CapaPresentacion
{
    partial class Form1
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
            btnAltaPersona_frmFrom1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(1141, 305);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(274, 59);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1006, 605);
            dataGridView1.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(1206, 71);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(209, 27);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(1206, 112);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(209, 27);
            txtClave.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1206, 151);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1206, 189);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1206, 228);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(1206, 267);
            txtIdPersona.Margin = new Padding(3, 4, 3, 4);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(209, 27);
            txtIdPersona.TabIndex = 9;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(1082, 74);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(1155, 112);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(45, 20);
            lblClave.TabIndex = 12;
            lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(1131, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(1131, 189);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(1149, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblIdPersona
            // 
            lblIdPersona.AutoSize = true;
            lblIdPersona.Location = new Point(1122, 267);
            lblIdPersona.Name = "lblIdPersona";
            lblIdPersona.Size = new Size(73, 20);
            lblIdPersona.TabIndex = 16;
            lblIdPersona.Text = "IdPersona";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(14, 652);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(122, 652);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(86, 31);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAltaPersona_frmFrom1
            // 
            btnAltaPersona_frmFrom1.Location = new Point(1141, 415);
            btnAltaPersona_frmFrom1.Margin = new Padding(3, 4, 3, 4);
            btnAltaPersona_frmFrom1.Name = "btnAltaPersona_frmFrom1";
            btnAltaPersona_frmFrom1.Size = new Size(274, 59);
            btnAltaPersona_frmFrom1.TabIndex = 19;
            btnAltaPersona_frmFrom1.Text = "Alta de persona";
            btnAltaPersona_frmFrom1.UseVisualStyleBackColor = true;
            btnAltaPersona_frmFrom1.Click += btnAltaPersona_frmFrom1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 748);
            Controls.Add(btnAltaPersona_frmFrom1);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnAltaPersona_frmFrom1;
    }
}