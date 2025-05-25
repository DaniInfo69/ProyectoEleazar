namespace Restaurante
{
    partial class Puestos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdPuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puesto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(570, 321);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 59);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPuesto,
            this.Puesto});
            this.dgvPuestos.Location = new System.Drawing.Point(36, 306);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.RowTemplate.Height = 24;
            this.dgvPuestos.Size = new System.Drawing.Size(500, 293);
            this.dgvPuestos.TabIndex = 3;
            this.dgvPuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuestos_CellContentClick);
            // 
            // IdPuesto
            // 
            this.IdPuesto.HeaderText = "IdPuesto";
            this.IdPuesto.MinimumWidth = 7;
            this.IdPuesto.Name = "IdPuesto";
            this.IdPuesto.ReadOnly = true;
            this.IdPuesto.Width = 135;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 7;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Width = 135;
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Location = new System.Drawing.Point(386, 66);
            this.txtIdPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(150, 35);
            this.txtIdPuesto.TabIndex = 4;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(386, 179);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(150, 35);
            this.txtPuesto.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(476, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 52);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(284, 246);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 52);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(871, 687);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtIdPuesto);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.Puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
    }
}