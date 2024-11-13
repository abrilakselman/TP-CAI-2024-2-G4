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
            this.ButtonVolverVxV = new System.Windows.Forms.Button();
            this.ButtonGenerarVxV = new System.Windows.Forms.Button();
            this.labelVentasxVendedor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // ButtonVolverVxV
            // 
            this.ButtonVolverVxV.BackColor = System.Drawing.Color.Blue;
            this.ButtonVolverVxV.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVolverVxV.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVolverVxV.Location = new System.Drawing.Point(879, 609);
            this.ButtonVolverVxV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonVolverVxV.Name = "ButtonVolverVxV";
            this.ButtonVolverVxV.Size = new System.Drawing.Size(200, 57);
            this.ButtonVolverVxV.TabIndex = 7;
            this.ButtonVolverVxV.Text = "Volver";
            this.ButtonVolverVxV.UseVisualStyleBackColor = false;
            // 
            // ButtonGenerarVxV
            // 
            this.ButtonGenerarVxV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonGenerarVxV.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerarVxV.Location = new System.Drawing.Point(678, 117);
            this.ButtonGenerarVxV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGenerarVxV.Name = "ButtonGenerarVxV";
            this.ButtonGenerarVxV.Size = new System.Drawing.Size(200, 57);
            this.ButtonGenerarVxV.TabIndex = 6;
            this.ButtonGenerarVxV.Text = "Generar";
            this.ButtonGenerarVxV.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(697, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVentasPorVendedorMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVentarxVendor);
            this.Controls.Add(this.cmbVentasxVendedor);
            this.Controls.Add(this.ButtonVolverVxV);
            this.Controls.Add(this.ButtonGenerarVxV);
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
        private System.Windows.Forms.Button ButtonVolverVxV;
        private System.Windows.Forms.Button ButtonGenerarVxV;
        private System.Windows.Forms.Label labelVentasxVendedor;
        private System.Windows.Forms.Button button1;
    }
}