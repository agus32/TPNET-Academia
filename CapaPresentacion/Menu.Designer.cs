namespace CapaPresentacion
{
    partial class Menu
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
            lblAdmin = new Label();
            btnMaterias = new Button();
            btnUsuarios = new Button();
            btnPersona = new Button();
            btnCursos = new Button();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(12, 26);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(145, 15);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Bienvenido Administrador";
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(12, 72);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(182, 63);
            btnMaterias.TabIndex = 1;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(12, 176);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(182, 63);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(12, 267);
            btnPersona.Margin = new Padding(3, 2, 3, 2);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(182, 62);
            btnPersona.TabIndex = 3;
            btnPersona.Text = "Personas";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(286, 72);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(182, 63);
            btnCursos.TabIndex = 4;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCursos);
            Controls.Add(btnPersona);
            Controls.Add(btnUsuarios);
            Controls.Add(btnMaterias);
            Controls.Add(lblAdmin);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private Button btnMaterias;
        private Button btnUsuarios;
        private Button btnPersona;
        private Button btnCursos;
    }
}