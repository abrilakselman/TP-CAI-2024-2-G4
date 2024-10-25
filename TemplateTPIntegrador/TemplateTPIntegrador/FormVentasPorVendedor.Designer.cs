namespace TemplateTPIntegrador
{
    partial class FormVentasPorVendedor
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
            this.ButtonGenerar = new System.Windows.Forms.Button();
            this.ButtonVolver = new System.Windows.Forms.Button();
            this.cmbVentasxVendedor = new System.Windows.Forms.ComboBox();
            this.dgvVentarxVendor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Gestion -Ventas por vendedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonGenerar
            // 
            this.ButtonGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerar.Location = new System.Drawing.Point(233, 76);
            this.ButtonGenerar.Name = "ButtonGenerar";
            this.ButtonGenerar.Size = new System.Drawing.Size(133, 37);
            this.ButtonGenerar.TabIndex = 1;
            this.ButtonGenerar.Text = "Generar";
            this.ButtonGenerar.UseVisualStyleBackColor = false;
            // 
            // ButtonVolver
            // 
            this.ButtonVolver.BackColor = System.Drawing.Color.Blue;
            this.ButtonVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVolver.Location = new System.Drawing.Point(372, 76);
            this.ButtonVolver.Name = "ButtonVolver";
            this.ButtonVolver.Size = new System.Drawing.Size(133, 37);
            this.ButtonVolver.TabIndex = 2;
            this.ButtonVolver.Text = "Volver";
            this.ButtonVolver.UseVisualStyleBackColor = false;
            // 
            // cmbVentasxVendedor
            // 
            this.cmbVentasxVendedor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbVentasxVendedor.FormattingEnabled = true;
            this.cmbVentasxVendedor.Location = new System.Drawing.Point(272, 119);
            this.cmbVentasxVendedor.Name = "cmbVentasxVendedor";
            this.cmbVentasxVendedor.Size = new System.Drawing.Size(195, 21);
            this.cmbVentasxVendedor.TabIndex = 3;
            // 
            // dgvVentarxVendor
            // 
            this.dgvVentarxVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentarxVendor.Location = new System.Drawing.Point(57, 159);
            this.dgvVentarxVendor.Name = "dgvVentarxVendor";
            this.dgvVentarxVendor.Size = new System.Drawing.Size(661, 238);
            this.dgvVentarxVendor.TabIndex = 4;
            // 
            // FormVentasPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.dgvVentarxVendor);
            this.Controls.Add(this.cmbVentasxVendedor);
            this.Controls.Add(this.ButtonVolver);
            this.Controls.Add(this.ButtonGenerar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVentasPorVendedor";
            this.Text = "Ventas Por Vendedor";
            this.Load += new System.EventHandler(this.FormVentasPorVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGenerar;
        private System.Windows.Forms.Button ButtonVolver;
        private System.Windows.Forms.ComboBox cmbVentasxVendedor;
        private System.Windows.Forms.DataGridView dgvVentarxVendor;
    }
}