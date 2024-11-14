namespace TemplateTPIntegrador
{
    partial class FormVentasPorVendedorMenuVendedor
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
            this.dgvVentarxVendor = new System.Windows.Forms.DataGridView();
            this.cmbVentasxVendedor = new System.Windows.Forms.ComboBox();
            this.labelVentasxVendedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentarxVendor
            // 
            this.dgvVentarxVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentarxVendor.Location = new System.Drawing.Point(30, 204);
            this.dgvVentarxVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentarxVendor.Name = "dgvVentarxVendor";
            this.dgvVentarxVendor.RowHeadersWidth = 62;
            this.dgvVentarxVendor.Size = new System.Drawing.Size(992, 306);
            this.dgvVentarxVendor.TabIndex = 9;
            // 
            // cmbVentasxVendedor
            // 
            this.cmbVentasxVendedor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbVentasxVendedor.FormattingEnabled = true;
            this.cmbVentasxVendedor.Location = new System.Drawing.Point(355, 129);
            this.cmbVentasxVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVentasxVendedor.Name = "cmbVentasxVendedor";
            this.cmbVentasxVendedor.Size = new System.Drawing.Size(290, 28);
            this.cmbVentasxVendedor.TabIndex = 8;
            // 
            // labelVentasxVendedor
            // 
            this.labelVentasxVendedor.AutoSize = true;
            this.labelVentasxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentasxVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVentasxVendedor.Location = new System.Drawing.Point(105, 17);
            this.labelVentasxVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVentasxVendedor.Name = "labelVentasxVendedor";
            this.labelVentasxVendedor.Size = new System.Drawing.Size(825, 47);
            this.labelVentasxVendedor.TabIndex = 5;
            this.labelVentasxVendedor.Text = "Reporte de Gestion -Ventas por vendedor";
            // 
            // FormVentasPorVendedorMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 674);
            this.Controls.Add(this.dgvVentarxVendor);
            this.Controls.Add(this.cmbVentasxVendedor);
            this.Controls.Add(this.labelVentasxVendedor);
            this.Name = "FormVentasPorVendedorMenuVendedor";
            this.Text = "Reporte Ventas Por Vendedor";
            this.Load += new System.EventHandler(this.FormVentasPorVendedorMenuVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentarxVendor;
        private System.Windows.Forms.ComboBox cmbVentasxVendedor;
        private System.Windows.Forms.Label labelVentasxVendedor;
    }
}