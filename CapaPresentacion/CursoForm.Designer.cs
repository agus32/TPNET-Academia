namespace CapaPresentacion
{
    partial class CursoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEnviar = new Button();
            lblIdMateria = new Label();
            txtIdMateria = new TextBox();
            txtIdComision = new TextBox();
            txtAnioCalendario = new TextBox();
            txtCupo = new TextBox();
            lblIdComision = new Label();
            lblAnioCalendario = new Label();
            lblCupo = new Label();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 330);
            dataGridView1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(633, 221);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(130, 40);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblIdMateria
            // 
            lblIdMateria.AutoSize = true;
            lblIdMateria.Location = new Point(567, 61);
            lblIdMateria.Name = "lblIdMateria";
            lblIdMateria.Size = new Size(60, 15);
            lblIdMateria.TabIndex = 2;
            lblIdMateria.Text = "Id Materia";
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new Point(633, 61);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new Size(130, 23);
            txtIdMateria.TabIndex = 3;
            // 
            // txtIdComision
            // 
            txtIdComision.Location = new Point(633, 102);
            txtIdComision.Name = "txtIdComision";
            txtIdComision.Size = new Size(130, 23);
            txtIdComision.TabIndex = 4;
            // 
            // txtAnioCalendario
            // 
            txtAnioCalendario.Location = new Point(633, 140);
            txtAnioCalendario.Name = "txtAnioCalendario";
            txtAnioCalendario.Size = new Size(130, 23);
            txtAnioCalendario.TabIndex = 5;
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(633, 182);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(130, 23);
            txtCupo.TabIndex = 6;
            // 
            // lblIdComision
            // 
            lblIdComision.AutoSize = true;
            lblIdComision.Location = new Point(556, 102);
            lblIdComision.Name = "lblIdComision";
            lblIdComision.Size = new Size(71, 15);
            lblIdComision.TabIndex = 7;
            lblIdComision.Text = "Id Comision";
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Location = new Point(538, 140);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(89, 15);
            lblAnioCalendario.TabIndex = 8;
            lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(591, 182);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(36, 15);
            lblCupo.TabIndex = 9;
            lblCupo.Text = "Cupo";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(93, 349);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 349);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(633, 366);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(130, 72);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Volver al Menu Principal";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // CursoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(lblCupo);
            Controls.Add(lblAnioCalendario);
            Controls.Add(lblIdComision);
            Controls.Add(txtCupo);
            Controls.Add(txtAnioCalendario);
            Controls.Add(txtIdComision);
            Controls.Add(txtIdMateria);
            Controls.Add(lblIdMateria);
            Controls.Add(btnEnviar);
            Controls.Add(dataGridView1);
            Name = "CursoForm";
            Text = "Cursos";
            Load += CursoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEnviar;
        private Label lblIdMateria;
        private TextBox txtIdMateria;
        private TextBox txtIdComision;
        private TextBox txtAnioCalendario;
        private TextBox txtCupo;
        private Label lblIdComision;
        private Label lblAnioCalendario;
        private Label lblCupo;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnMenu;
    }
}