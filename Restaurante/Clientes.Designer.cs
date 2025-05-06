namespace Restaurante
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txIdCliente = new System.Windows.Forms.TextBox();
            this.txColonia = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDomicilioC = new System.Windows.Forms.TextBox();
            this.txCP = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colonia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "CP";
            // 
            // txIdCliente
            // 
            this.txIdCliente.Enabled = false;
            this.txIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIdCliente.Location = new System.Drawing.Point(219, 150);
            this.txIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txIdCliente.Name = "txIdCliente";
            this.txIdCliente.Size = new System.Drawing.Size(124, 30);
            this.txIdCliente.TabIndex = 6;
            // 
            // txColonia
            // 
            this.txColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txColonia.Location = new System.Drawing.Point(626, 233);
            this.txColonia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txColonia.Name = "txColonia";
            this.txColonia.Size = new System.Drawing.Size(124, 30);
            this.txColonia.TabIndex = 7;
            // 
            // txTelefono
            // 
            this.txTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelefono.Location = new System.Drawing.Point(219, 228);
            this.txTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(124, 30);
            this.txTelefono.TabIndex = 8;
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(626, 156);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(124, 30);
            this.txNombre.TabIndex = 9;
            // 
            // txDomicilioC
            // 
            this.txDomicilioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDomicilioC.Location = new System.Drawing.Point(338, 309);
            this.txDomicilioC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txDomicilioC.Name = "txDomicilioC";
            this.txDomicilioC.Size = new System.Drawing.Size(124, 30);
            this.txDomicilioC.TabIndex = 10;
            // 
            // txCP
            // 
            this.txCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCP.Location = new System.Drawing.Point(626, 314);
            this.txCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txCP.Name = "txCP";
            this.txCP.Size = new System.Drawing.Size(124, 30);
            this.txCP.TabIndex = 11;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Telefono,
            this.Colonia,
            this.DomicilioCliente,
            this.CP});
            this.dgvClientes.Location = new System.Drawing.Point(22, 408);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(798, 489);
            this.dgvClientes.TabIndex = 12;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "idCliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Colonia
            // 
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.MinimumWidth = 6;
            this.Colonia.Name = "Colonia";
            this.Colonia.ReadOnly = true;
            this.Colonia.Width = 125;
            // 
            // DomicilioCliente
            // 
            this.DomicilioCliente.HeaderText = "Domicilio Cliente";
            this.DomicilioCliente.MinimumWidth = 6;
            this.DomicilioCliente.Name = "DomicilioCliente";
            this.DomicilioCliente.ReadOnly = true;
            this.DomicilioCliente.Width = 125;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.MinimumWidth = 6;
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1002, 364);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 80);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 61);
            this.label7.TabIndex = 15;
            this.label7.Text = "Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Logo_La_Indita;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1301, 765);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txCP);
            this.Controls.Add(this.txDomicilioC);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.txColonia);
            this.Controls.Add(this.txIdCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Clientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txIdCliente;
        private System.Windows.Forms.TextBox txColonia;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDomicilioC;
        private System.Windows.Forms.TextBox txCP;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

