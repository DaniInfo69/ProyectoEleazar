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
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdPuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puesto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(656, 341);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 80);
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
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Location = new System.Drawing.Point(386, 99);
            this.txtIdPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(150, 35);
            this.txtIdPuesto.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 465);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 80);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(386, 212);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(150, 35);
            this.txtPuesto.TabIndex = 8;
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
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(871, 687);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}