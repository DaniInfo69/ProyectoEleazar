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
            this.txIdEmpleado = new System.Windows.Forms.TextBox();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.txIdPuesto = new System.Windows.Forms.TextBox();
            this.txNombreE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txIdEmpleado
            // 
            this.txIdEmpleado.Enabled = false;
            this.txIdEmpleado.Location = new System.Drawing.Point(658, 37);
            this.txIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txIdEmpleado.Name = "txIdEmpleado";
            this.txIdEmpleado.Size = new System.Drawing.Size(136, 36);
            this.txIdEmpleado.TabIndex = 0;
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(214, 189);
            this.txApellido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(136, 36);
            this.txApellido.TabIndex = 1;
            // 
            // txIdPuesto
            // 
            this.txIdPuesto.Location = new System.Drawing.Point(658, 108);
            this.txIdPuesto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txIdPuesto.Name = "txIdPuesto";
            this.txIdPuesto.Size = new System.Drawing.Size(58, 36);
            this.txIdPuesto.TabIndex = 2;
            // 
            // txNombreE
            // 
            this.txNombreE.Location = new System.Drawing.Point(214, 108);
            this.txNombreE.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txNombreE.Name = "txNombreE";
            this.txNombreE.Size = new System.Drawing.Size(136, 36);
            this.txNombreE.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "IdEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "IdPuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(658, 280);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(136, 36);
            this.txEmail.TabIndex = 8;
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(214, 277);
            this.txTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(136, 36);
            this.txTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.IdPuesto,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Email});
            this.dgvEmpleados.Location = new System.Drawing.Point(51, 352);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(800, 306);
            this.dgvEmpleados.TabIndex = 12;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.MinimumWidth = 6;
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Width = 125;
            // 
            // IdPuesto
            // 
            this.IdPuesto.HeaderText = "IdPuesto";
            this.IdPuesto.MinimumWidth = 6;
            this.IdPuesto.Name = "IdPuesto";
            this.IdPuesto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.Location = new System.Drawing.Point(869, 472);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 62);
            this.button3.TabIndex = 13;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = false;
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
            this.label7.Location = new System.Drawing.Point(542, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "Puesto";
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Encargado",
            "Mesero",
            "Cocinero"});
            this.cbPuesto.Location = new System.Drawing.Point(658, 192);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(136, 41);
            this.cbPuesto.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 61);
            this.label8.TabIndex = 18;
            this.label8.Text = "Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Logo_La_Indita;
            this.pictureBox1.Location = new System.Drawing.Point(34, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1036, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNombreE);
            this.Controls.Add(this.txIdPuesto);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.txIdEmpleado);
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

        private System.Windows.Forms.TextBox txIdEmpleado;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.TextBox txIdPuesto;
        private System.Windows.Forms.TextBox txNombreE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}