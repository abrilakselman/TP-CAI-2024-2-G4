namespace TemplateTPIntegrador
{
    partial class FormListaProveedor
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
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.btnBajaProv = new System.Windows.Forms.Button();
            this.btnAltaProv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Location = new System.Drawing.Point(23, 82);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersWidth = 62;
            this.dgvListaProveedores.RowTemplate.Height = 28;
            this.dgvListaProveedores.Size = new System.Drawing.Size(776, 497);
            this.dgvListaProveedores.TabIndex = 0;
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.Location = new System.Drawing.Point(829, 362);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(156, 54);
            this.btnModificarProv.TabIndex = 7;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = true;
            // 
            // btnBajaProv
            // 
            this.btnBajaProv.Location = new System.Drawing.Point(829, 268);
            this.btnBajaProv.Name = "btnBajaProv";
            this.btnBajaProv.Size = new System.Drawing.Size(156, 54);
            this.btnBajaProv.TabIndex = 6;
            this.btnBajaProv.Text = "Baja";
            this.btnBajaProv.UseVisualStyleBackColor = true;
            // 
            // btnAltaProv
            // 
            this.btnAltaProv.Location = new System.Drawing.Point(829, 177);
            this.btnAltaProv.Name = "btnAltaProv";
            this.btnAltaProv.Size = new System.Drawing.Size(156, 54);
            this.btnAltaProv.TabIndex = 5;
            this.btnAltaProv.Text = "Alta";
            this.btnAltaProv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Proveedores";
            // 
            // FormListaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarProv);
            this.Controls.Add(this.btnBajaProv);
            this.Controls.Add(this.btnAltaProv);
            this.Controls.Add(this.dgvListaProveedores);
            this.Name = "FormListaProveedor";
            this.Text = "Lista de Proveedor";
            this.Load += new System.EventHandler(this.FormListaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.Button btnBajaProv;
        private System.Windows.Forms.Button btnAltaProv;
        private System.Windows.Forms.Label label1;
    }
}