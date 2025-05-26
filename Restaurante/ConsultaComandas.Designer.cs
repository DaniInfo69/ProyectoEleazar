namespace Restaurante
{
    partial class ConsultaComandas
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
            this.cboIdComanda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleComanda = new System.Windows.Forms.DataGridView();
            this.IdComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnActivas = new System.Windows.Forms.RadioButton();
            this.rbtnCanceladas = new System.Windows.Forms.RadioButton();
            this.rbtnPagadas = new System.Windows.Forms.RadioButton();
            this.rbtnGeneral = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleComanda)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboIdComanda
            // 
            this.cboIdComanda.FormattingEnabled = true;
            this.cboIdComanda.Location = new System.Drawing.Point(589, 446);
            this.cboIdComanda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboIdComanda.Name = "cboIdComanda";
            this.cboIdComanda.Size = new System.Drawing.Size(180, 40);
            this.cboIdComanda.TabIndex = 43;
            this.cboIdComanda.SelectedIndexChanged += new System.EventHandler(this.cboIdComanda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(472, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 42;
            this.label4.Text = "IdComanda";
            // 
            // dgvComanda
            // 
            this.dgvComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvComanda.Location = new System.Drawing.Point(76, 154);
            this.dgvComanda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.RowHeadersWidth = 45;
            this.dgvComanda.Size = new System.Drawing.Size(1206, 278);
            this.dgvComanda.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdComanda";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empleado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SubTotal";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IVA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Estado";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dgvDetalleComanda
            // 
            this.dgvDetalleComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleComanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdComanda,
            this.IdMenu,
            this.Descripción,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvDetalleComanda.Location = new System.Drawing.Point(76, 528);
            this.dgvDetalleComanda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvDetalleComanda.Name = "dgvDetalleComanda";
            this.dgvDetalleComanda.RowHeadersWidth = 45;
            this.dgvDetalleComanda.Size = new System.Drawing.Size(1212, 220);
            this.dgvDetalleComanda.TabIndex = 40;
            // 
            // IdComanda
            // 
            this.IdComanda.HeaderText = "IdComanda";
            this.IdComanda.MinimumWidth = 6;
            this.IdComanda.Name = "IdComanda";
            // 
            // IdMenu
            // 
            this.IdMenu.HeaderText = "IdMenú";
            this.IdMenu.MinimumWidth = 6;
            this.IdMenu.Name = "IdMenu";
            this.IdMenu.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(76, 17);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 53);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnGeneral);
            this.groupBox5.Controls.Add(this.rbtnActivas);
            this.groupBox5.Controls.Add(this.rbtnCanceladas);
            this.groupBox5.Controls.Add(this.rbtnPagadas);
            this.groupBox5.Location = new System.Drawing.Point(445, 26);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox5.Size = new System.Drawing.Size(397, 127);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtro";
            // 
            // rbtnActivas
            // 
            this.rbtnActivas.AutoSize = true;
            this.rbtnActivas.BackColor = System.Drawing.Color.Transparent;
            this.rbtnActivas.Location = new System.Drawing.Point(282, 40);
            this.rbtnActivas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbtnActivas.Name = "rbtnActivas";
            this.rbtnActivas.Size = new System.Drawing.Size(93, 36);
            this.rbtnActivas.TabIndex = 25;
            this.rbtnActivas.Text = "Activas";
            this.rbtnActivas.UseVisualStyleBackColor = false;
            this.rbtnActivas.CheckedChanged += new System.EventHandler(this.rbtnActivas_CheckedChanged);
            // 
            // rbtnCanceladas
            // 
            this.rbtnCanceladas.AutoSize = true;
            this.rbtnCanceladas.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCanceladas.Location = new System.Drawing.Point(144, 40);
            this.rbtnCanceladas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbtnCanceladas.Name = "rbtnCanceladas";
            this.rbtnCanceladas.Size = new System.Drawing.Size(126, 36);
            this.rbtnCanceladas.TabIndex = 24;
            this.rbtnCanceladas.Text = "Canceladas";
            this.rbtnCanceladas.UseVisualStyleBackColor = false;
            this.rbtnCanceladas.CheckedChanged += new System.EventHandler(this.rbtnCanceladas_CheckedChanged);
            // 
            // rbtnPagadas
            // 
            this.rbtnPagadas.AutoSize = true;
            this.rbtnPagadas.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPagadas.Location = new System.Drawing.Point(30, 40);
            this.rbtnPagadas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbtnPagadas.Name = "rbtnPagadas";
            this.rbtnPagadas.Size = new System.Drawing.Size(102, 36);
            this.rbtnPagadas.TabIndex = 23;
            this.rbtnPagadas.Text = "Pagadas";
            this.rbtnPagadas.UseVisualStyleBackColor = false;
            this.rbtnPagadas.CheckedChanged += new System.EventHandler(this.rbtnPagadas_CheckedChanged);
            // 
            // rbtnGeneral
            // 
            this.rbtnGeneral.AutoSize = true;
            this.rbtnGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGeneral.Checked = true;
            this.rbtnGeneral.Location = new System.Drawing.Point(156, 78);
            this.rbtnGeneral.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbtnGeneral.Name = "rbtnGeneral";
            this.rbtnGeneral.Size = new System.Drawing.Size(100, 36);
            this.rbtnGeneral.TabIndex = 26;
            this.rbtnGeneral.TabStop = true;
            this.rbtnGeneral.Text = "General";
            this.rbtnGeneral.UseVisualStyleBackColor = false;
            this.rbtnGeneral.CheckedChanged += new System.EventHandler(this.rbtnGeneral_CheckedChanged);
            // 
            // ConsultaComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1448, 787);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cboIdComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.dgvDetalleComanda);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ConsultaComandas";
            this.Text = "ConsultaComandas";
            this.Load += new System.EventHandler(this.ConsultaComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleComanda)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdComanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.DataGridView dgvDetalleComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnCanceladas;
        private System.Windows.Forms.RadioButton rbtnPagadas;
        private System.Windows.Forms.RadioButton rbtnActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.RadioButton rbtnGeneral;
    }
}