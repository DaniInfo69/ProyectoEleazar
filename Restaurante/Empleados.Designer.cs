namespace Restaurante
{
    partial class Empleados
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txIdPuesto = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(658, 37);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 39);
            this.txtTelefono.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 186);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 39);
            this.txtNombre.TabIndex = 1;
            // 
            // txIdPuesto
            // 
            this.txIdPuesto.Enabled = false;
            this.txIdPuesto.Location = new System.Drawing.Point(658, 186);
            this.txIdPuesto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txIdPuesto.Name = "txIdPuesto";
            this.txIdPuesto.Size = new System.Drawing.Size(136, 39);
            this.txIdPuesto.TabIndex = 2;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(291, 108);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(59, 39);
            this.txtIdEmpleado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "IdPuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(658, 108);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 39);
            this.txtEmail.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(214, 255);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(136, 39);
            this.txtApellidos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apellidos";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.Puesto,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Email});
            this.dgvEmpleados.Location = new System.Drawing.Point(51, 352);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(810, 306);
            this.dgvEmpleados.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.Location = new System.Drawing.Point(869, 472);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 62);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.Location = new System.Drawing.Point(869, 381);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 62);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 1135);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 91);
            this.button2.TabIndex = 15;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Puesto";
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(658, 255);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(136, 44);
            this.cboPuesto.TabIndex = 17;
            this.cboPuesto.SelectedIndexChanged += new System.EventHandler(this.cboPuesto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 68);
            this.label8.TabIndex = 18;
            this.label8.Text = "Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Logo_La_Indita;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 36);
            this.label9.TabIndex = 26;
            this.label9.Text = "Id";
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.MinimumWidth = 6;
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Width = 125;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1036, 677);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txIdPuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txIdPuesto;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}