namespace CapaPresentacion
{
    partial class MateriaForm
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
            lblDescMateria = new Label();
            btnEnviar = new Button();
            txtDescMateria = new TextBox();
            dataGridView1 = new DataGridView();
            lblHsSemanales = new Label();
            lblHsTotales = new Label();
            lblIdPlan = new Label();
            txtHsSemanales = new TextBox();
            txtHsTotales = new TextBox();
            txtIdPlan = new TextBox();
            btnModificar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDescMateria
            // 
            lblDescMateria.AutoSize = true;
            lblDescMateria.Location = new Point(726, 75);
            lblDescMateria.Name = "lblDescMateria";
            lblDescMateria.Size = new Size(69, 15);
            lblDescMateria.TabIndex = 0;
            lblDescMateria.Text = "Descripcion";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(801, 248);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(170, 39);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtDescMateria
            // 
            txtDescMateria.Location = new Point(801, 75);
            txtDescMateria.Name = "txtDescMateria";
            txtDescMateria.Size = new Size(170, 23);
            txtDescMateria.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 408);
            dataGridView1.TabIndex = 3;
            // 
            // lblHsSemanales
            // 
            lblHsSemanales.AutoSize = true;
            lblHsSemanales.Location = new Point(698, 117);
            lblHsSemanales.Name = "lblHsSemanales";
            lblHsSemanales.Size = new Size(97, 15);
            lblHsSemanales.TabIndex = 4;
            lblHsSemanales.Text = "Horas Semanales";
            // 
            // lblHsTotales
            // 
            lblHsTotales.AutoSize = true;
            lblHsTotales.Location = new Point(718, 159);
            lblHsTotales.Name = "lblHsTotales";
            lblHsTotales.Size = new Size(77, 15);
            lblHsTotales.TabIndex = 5;
            lblHsTotales.Text = "Horas Totales";
            // 
            // lblIdPlan
            // 
            lblIdPlan.AutoSize = true;
            lblIdPlan.Location = new Point(752, 200);
            lblIdPlan.Name = "lblIdPlan";
            lblIdPlan.Size = new Size(43, 15);
            lblIdPlan.TabIndex = 6;
            lblIdPlan.Text = "Id Plan";
            // 
            // txtHsSemanales
            // 
            txtHsSemanales.Location = new Point(801, 117);
            txtHsSemanales.Name = "txtHsSemanales";
            txtHsSemanales.Size = new Size(170, 23);
            txtHsSemanales.TabIndex = 7;
            // 
            // txtHsTotales
            // 
            txtHsTotales.Location = new Point(801, 159);
            txtHsTotales.Name = "txtHsTotales";
            txtHsTotales.Size = new Size(170, 23);
            txtHsTotales.TabIndex = 8;
            // 
            // txtIdPlan
            // 
            txtIdPlan.Location = new Point(801, 200);
            txtIdPlan.Name = "txtIdPlan";
            txtIdPlan.Size = new Size(170, 23);
            txtIdPlan.TabIndex = 9;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 446);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(109, 446);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // MateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 512);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(txtIdPlan);
            Controls.Add(txtHsTotales);
            Controls.Add(txtHsSemanales);
            Controls.Add(lblIdPlan);
            Controls.Add(lblHsTotales);
            Controls.Add(lblHsSemanales);
            Controls.Add(dataGridView1);
            Controls.Add(txtDescMateria);
            Controls.Add(btnEnviar);
            Controls.Add(lblDescMateria);
            Name = "MateriaForm";
            Text = "MateriaForm";
            Load += MateriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescMateria;
        private Button btnEnviar;
        private TextBox txtDescMateria;
        private DataGridView dataGridView1;
        private Label lblHsSemanales;
        private Label lblHsTotales;
        private Label lblIdPlan;
        private TextBox txtHsSemanales;
        private TextBox txtHsTotales;
        private TextBox txtIdPlan;
        private Button btnModificar;
        private Button btnBorrar;
    }
}