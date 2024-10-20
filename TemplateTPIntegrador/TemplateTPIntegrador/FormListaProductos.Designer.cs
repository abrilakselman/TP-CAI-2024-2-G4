namespace TemplateTPIntegrador
{
    partial class FormListaProductos
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
            this.dvgListaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarProd = new System.Windows.Forms.Button();
            this.btnBajaProd = new System.Windows.Forms.Button();
            this.btnAltaProd = new System.Windows.Forms.Button();
            this.comboBoxCatProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListaProductos
            // 
            this.dvgListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListaProductos.Location = new System.Drawing.Point(12, 84);
            this.dvgListaProductos.Name = "dvgListaProductos";
            this.dvgListaProductos.RowHeadersWidth = 62;
            this.dvgListaProductos.RowTemplate.Height = 28;
            this.dvgListaProductos.Size = new System.Drawing.Size(792, 480);
            this.dvgListaProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Productos";
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.Location = new System.Drawing.Point(913, 444);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(156, 54);
            this.btnModificarProd.TabIndex = 7;
            this.btnModificarProd.Text = "Modificar";
            this.btnModificarProd.UseVisualStyleBackColor = true;
            // 
            // btnBajaProd
            // 
            this.btnBajaProd.Location = new System.Drawing.Point(913, 350);
            this.btnBajaProd.Name = "btnBajaProd";
            this.btnBajaProd.Size = new System.Drawing.Size(156, 54);
            this.btnBajaProd.TabIndex = 6;
            this.btnBajaProd.Text = "Baja";
            this.btnBajaProd.UseVisualStyleBackColor = true;
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.Location = new System.Drawing.Point(913, 259);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Size = new System.Drawing.Size(156, 54);
            this.btnAltaProd.TabIndex = 5;
            this.btnAltaProd.Text = "Alta";
            this.btnAltaProd.UseVisualStyleBackColor = true;
            // 
            // comboBoxCatProducto
            // 
            this.comboBoxCatProducto.FormattingEnabled = true;
            this.comboBoxCatProducto.Location = new System.Drawing.Point(838, 161);
            this.comboBoxCatProducto.Name = "comboBoxCatProducto";
            this.comboBoxCatProducto.Size = new System.Drawing.Size(191, 28);
            this.comboBoxCatProducto.TabIndex = 8;
            this.comboBoxCatProducto.SelectedIndexChanged += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Elija una categoria:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1058, 150);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 49);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 576);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCatProducto);
            this.Controls.Add(this.btnModificarProd);
            this.Controls.Add(this.btnBajaProd);
            this.Controls.Add(this.btnAltaProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgListaProductos);
            this.Name = "FormListaProductos";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FormListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarProd;
        private System.Windows.Forms.Button btnBajaProd;
        private System.Windows.Forms.Button btnAltaProd;
        private System.Windows.Forms.ComboBox comboBoxCatProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
    }
}