namespace TemplateTPIntegrador
{
    partial class FormReporteVenidoPorCategoria
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
            this.ButtonGenerarPvxC = new System.Windows.Forms.Button();
            this.ButtonVolverPVxC = new System.Windows.Forms.Button();
            this.LabelProdVendxCat = new System.Windows.Forms.Label();
            this.cmbPVxC = new System.Windows.Forms.ComboBox();
            this.dgvPVxC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVxC)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGenerarPvxC
            // 
            this.ButtonGenerarPvxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonGenerarPvxC.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerarPvxC.Location = new System.Drawing.Point(451, 68);
            this.ButtonGenerarPvxC.Name = "ButtonGenerarPvxC";
            this.ButtonGenerarPvxC.Size = new System.Drawing.Size(133, 37);
            this.ButtonGenerarPvxC.TabIndex = 2;
            this.ButtonGenerarPvxC.Text = "Generar";
            this.ButtonGenerarPvxC.UseVisualStyleBackColor = false;
            // 
            // ButtonVolverPVxC
            // 
            this.ButtonVolverPVxC.BackColor = System.Drawing.Color.Blue;
            this.ButtonVolverPVxC.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVolverPVxC.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVolverPVxC.Location = new System.Drawing.Point(636, 401);
            this.ButtonVolverPVxC.Name = "ButtonVolverPVxC";
            this.ButtonVolverPVxC.Size = new System.Drawing.Size(133, 37);
            this.ButtonVolverPVxC.TabIndex = 3;
            this.ButtonVolverPVxC.Text = "Volver";
            this.ButtonVolverPVxC.UseVisualStyleBackColor = false;
            // 
            // LabelProdVendxCat
            // 
            this.LabelProdVendxCat.AutoSize = true;
            this.LabelProdVendxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProdVendxCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelProdVendxCat.Location = new System.Drawing.Point(48, 9);
            this.LabelProdVendxCat.Name = "LabelProdVendxCat";
            this.LabelProdVendxCat.Size = new System.Drawing.Size(721, 31);
            this.LabelProdVendxCat.TabIndex = 4;
            this.LabelProdVendxCat.Text = "Reporte de Gestion -Productos vendidos por categoria";
            // 
            // cmbPVxC
            // 
            this.cmbPVxC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbPVxC.FormattingEnabled = true;
            this.cmbPVxC.Location = new System.Drawing.Point(230, 76);
            this.cmbPVxC.Name = "cmbPVxC";
            this.cmbPVxC.Size = new System.Drawing.Size(195, 21);
            this.cmbPVxC.TabIndex = 5;
            // 
            // dgvPVxC
            // 
            this.dgvPVxC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPVxC.Location = new System.Drawing.Point(65, 131);
            this.dgvPVxC.Name = "dgvPVxC";
            this.dgvPVxC.Size = new System.Drawing.Size(661, 238);
            this.dgvPVxC.TabIndex = 6;
            // 
            // FormReporteVenidoPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPVxC);
            this.Controls.Add(this.cmbPVxC);
            this.Controls.Add(this.LabelProdVendxCat);
            this.Controls.Add(this.ButtonVolverPVxC);
            this.Controls.Add(this.ButtonGenerarPvxC);
            this.Name = "FormReporteVenidoPorCategoria";
            this.Text = "FormReporteVenidoPorCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVxC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonGenerarPvxC;
        private System.Windows.Forms.Button ButtonVolverPVxC;
        private System.Windows.Forms.Label LabelProdVendxCat;
        private System.Windows.Forms.ComboBox cmbPVxC;
        private System.Windows.Forms.DataGridView dgvPVxC;
    }
}