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
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(14, 35);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(182, 20);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "Bienvenido Administrador";
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(14, 96);
            btnMaterias.Margin = new Padding(3, 4, 3, 4);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(208, 84);
            btnMaterias.TabIndex = 1;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(14, 235);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(208, 84);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(14, 356);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(208, 83);
            btnPersona.TabIndex = 3;
            btnPersona.Text = "Personas";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnPersona);
            Controls.Add(btnUsuarios);
            Controls.Add(btnMaterias);
            Controls.Add(lblAdmin);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}