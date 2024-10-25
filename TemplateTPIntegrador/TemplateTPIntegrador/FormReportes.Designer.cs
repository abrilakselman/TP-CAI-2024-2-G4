namespace TemplateTPIntegrador
{
    partial class FormReportes
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
            this.btnStockCritico = new System.Windows.Forms.Button();
            this.btnVtasXVendedor = new System.Windows.Forms.Button();
            this.btnProdMasVendidoXCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes:";
            // 
            // btnStockCritico
            // 
            this.btnStockCritico.Location = new System.Drawing.Point(89, 182);
            this.btnStockCritico.Name = "btnStockCritico";
            this.btnStockCritico.Size = new System.Drawing.Size(185, 95);
            this.btnStockCritico.TabIndex = 1;
            this.btnStockCritico.Text = "Stock Crítico";
            this.btnStockCritico.UseVisualStyleBackColor = true;
            this.btnStockCritico.Click += new System.EventHandler(this.btnStockCritico_Click);
            // 
            // btnVtasXVendedor
            // 
            this.btnVtasXVendedor.Location = new System.Drawing.Point(306, 182);
            this.btnVtasXVendedor.Name = "btnVtasXVendedor";
            this.btnVtasXVendedor.Size = new System.Drawing.Size(184, 95);
            this.btnVtasXVendedor.TabIndex = 2;
            this.btnVtasXVendedor.Text = "Ventas por Vendedor";
            this.btnVtasXVendedor.UseVisualStyleBackColor = true;
            this.btnVtasXVendedor.Click += new System.EventHandler(this.btnVtasXVendedor_Click);
            // 
            // btnProdMasVendidoXCategoria
            // 
            this.btnProdMasVendidoXCategoria.Location = new System.Drawing.Point(519, 182);
            this.btnProdMasVendidoXCategoria.Name = "btnProdMasVendidoXCategoria";
            this.btnProdMasVendidoXCategoria.Size = new System.Drawing.Size(199, 95);
            this.btnProdMasVendidoXCategoria.TabIndex = 3;
            this.btnProdMasVendidoXCategoria.Text = "Productos más vendidos por Categoría";
            this.btnProdMasVendidoXCategoria.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProdMasVendidoXCategoria);
            this.Controls.Add(this.btnVtasXVendedor);
            this.Controls.Add(this.btnStockCritico);
            this.Controls.Add(this.label1);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStockCritico;
        private System.Windows.Forms.Button btnVtasXVendedor;
        private System.Windows.Forms.Button btnProdMasVendidoXCategoria;
    }
}