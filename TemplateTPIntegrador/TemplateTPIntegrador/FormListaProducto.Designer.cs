namespace TemplateTPIntegrador
{
    partial class FormListaProducto
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
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAltaProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBajaProd = new System.Windows.Forms.Button();
            this.buttonModificarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(21, 77);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersWidth = 62;
            this.dgvListaProductos.RowTemplate.Height = 28;
            this.dgvListaProductos.Size = new System.Drawing.Size(833, 450);
            this.dgvListaProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Productos";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(880, 77);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(186, 28);
            this.comboBoxCat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(936, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAltaProd
            // 
            this.buttonAltaProd.Location = new System.Drawing.Point(916, 301);
            this.buttonAltaProd.Name = "buttonAltaProd";
            this.buttonAltaProd.Size = new System.Drawing.Size(141, 52);
            this.buttonAltaProd.TabIndex = 5;
            this.buttonAltaProd.Text = "Alta";
            this.buttonAltaProd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // buttonBajaProd
            // 
            this.buttonBajaProd.Location = new System.Drawing.Point(916, 380);
            this.buttonBajaProd.Name = "buttonBajaProd";
            this.buttonBajaProd.Size = new System.Drawing.Size(141, 52);
            this.buttonBajaProd.TabIndex = 7;
            this.buttonBajaProd.Text = "Baja";
            this.buttonBajaProd.UseVisualStyleBackColor = true;
            this.buttonBajaProd.Click += new System.EventHandler(this.buttonBajaProd_Click);
            // 
            // buttonModificarProd
            // 
            this.buttonModificarProd.Location = new System.Drawing.Point(916, 459);
            this.buttonModificarProd.Name = "buttonModificarProd";
            this.buttonModificarProd.Size = new System.Drawing.Size(141, 52);
            this.buttonModificarProd.TabIndex = 8;
            this.buttonModificarProd.Text = "Modificar";
            this.buttonModificarProd.UseVisualStyleBackColor = true;
            this.buttonModificarProd.Click += new System.EventHandler(this.buttonModificarProd_Click);
            // 
            // FormListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 539);
            this.Controls.Add(this.buttonModificarProd);
            this.Controls.Add(this.buttonBajaProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAltaProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProductos);
            this.Name = "FormListaProducto";
            this.Text = "FormListaProducto";
            this.Load += new System.EventHandler(this.FormListaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAltaProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBajaProd;
        private System.Windows.Forms.Button buttonModificarProd;
    }
}