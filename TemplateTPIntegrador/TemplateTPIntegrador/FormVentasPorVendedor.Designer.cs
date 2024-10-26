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
            this.labelVentasxVendedor = new System.Windows.Forms.Label();
            this.ButtonGenerarVxV = new System.Windows.Forms.Button();
            this.ButtonVolverVxV = new System.Windows.Forms.Button();
            this.cmbVentasxVendedor = new System.Windows.Forms.ComboBox();
            this.dgvVentarxVendor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVentasxVendedor
            // 
            this.labelVentasxVendedor.AutoSize = true;
            this.labelVentasxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentasxVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVentasxVendedor.Location = new System.Drawing.Point(108, 18);
            this.labelVentasxVendedor.Name = "labelVentasxVendedor";
            this.labelVentasxVendedor.Size = new System.Drawing.Size(555, 31);
            this.labelVentasxVendedor.TabIndex = 0;
            this.labelVentasxVendedor.Text = "Reporte de Gestion -Ventas por vendedor";
            this.labelVentasxVendedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonGenerarVxV
            // 
            this.ButtonGenerarVxV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonGenerarVxV.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerarVxV.Location = new System.Drawing.Point(490, 83);
            this.ButtonGenerarVxV.Name = "ButtonGenerarVxV";
            this.ButtonGenerarVxV.Size = new System.Drawing.Size(133, 37);
            this.ButtonGenerarVxV.TabIndex = 1;
            this.ButtonGenerarVxV.Text = "Generar";
            this.ButtonGenerarVxV.UseVisualStyleBackColor = false;
            // 
            // ButtonVolverVxV
            // 
            this.ButtonVolverVxV.BackColor = System.Drawing.Color.Blue;
            this.ButtonVolverVxV.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVolverVxV.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVolverVxV.Location = new System.Drawing.Point(624, 403);
            this.ButtonVolverVxV.Name = "ButtonVolverVxV";
            this.ButtonVolverVxV.Size = new System.Drawing.Size(133, 37);
            this.ButtonVolverVxV.TabIndex = 2;
            this.ButtonVolverVxV.Text = "Volver";
            this.ButtonVolverVxV.UseVisualStyleBackColor = false;
            // 
            // cmbVentasxVendedor
            // 
            this.cmbVentasxVendedor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbVentasxVendedor.FormattingEnabled = true;
            this.cmbVentasxVendedor.Location = new System.Drawing.Point(275, 91);
            this.cmbVentasxVendedor.Name = "cmbVentasxVendedor";
            this.cmbVentasxVendedor.Size = new System.Drawing.Size(195, 21);
            this.cmbVentasxVendedor.TabIndex = 3;
            // 
            // dgvVentarxVendor
            // 
            this.dgvVentarxVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentarxVendor.Location = new System.Drawing.Point(58, 140);
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
            this.Controls.Add(this.ButtonVolverVxV);
            this.Controls.Add(this.ButtonGenerarVxV);
            this.Controls.Add(this.labelVentasxVendedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVentasPorVendedor";
            this.Text = "Ventas Por Vendedor";
            this.Load += new System.EventHandler(this.FormVentasPorVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentarxVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVentasxVendedor;
        private System.Windows.Forms.Button ButtonGenerarVxV;
        private System.Windows.Forms.Button ButtonVolverVxV;
        private System.Windows.Forms.ComboBox cmbVentasxVendedor;
        private System.Windows.Forms.DataGridView dgvVentarxVendor;
    }
}