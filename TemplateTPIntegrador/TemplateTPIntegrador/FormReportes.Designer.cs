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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes:";
            // 
            // btnStockCritico
            // 
            this.btnStockCritico.BackColor = System.Drawing.Color.Navy;
            this.btnStockCritico.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockCritico.ForeColor = System.Drawing.Color.White;
            this.btnStockCritico.Location = new System.Drawing.Point(88, 182);
            this.btnStockCritico.Name = "btnStockCritico";
            this.btnStockCritico.Size = new System.Drawing.Size(184, 95);
            this.btnStockCritico.TabIndex = 1;
            this.btnStockCritico.Text = "Stock Crítico";
            this.btnStockCritico.UseVisualStyleBackColor = false;
            this.btnStockCritico.Click += new System.EventHandler(this.btnStockCritico_Click);
            // 
            // btnVtasXVendedor
            // 
            this.btnVtasXVendedor.BackColor = System.Drawing.Color.Navy;
            this.btnVtasXVendedor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVtasXVendedor.ForeColor = System.Drawing.Color.White;
            this.btnVtasXVendedor.Location = new System.Drawing.Point(306, 182);
            this.btnVtasXVendedor.Name = "btnVtasXVendedor";
            this.btnVtasXVendedor.Size = new System.Drawing.Size(184, 95);
            this.btnVtasXVendedor.TabIndex = 2;
            this.btnVtasXVendedor.Text = "Ventas por Vendedor";
            this.btnVtasXVendedor.UseVisualStyleBackColor = false;
            this.btnVtasXVendedor.Click += new System.EventHandler(this.btnVtasXVendedor_Click);
            // 
            // btnProdMasVendidoXCategoria
            // 
            this.btnProdMasVendidoXCategoria.BackColor = System.Drawing.Color.Navy;
            this.btnProdMasVendidoXCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdMasVendidoXCategoria.ForeColor = System.Drawing.Color.White;
            this.btnProdMasVendidoXCategoria.Location = new System.Drawing.Point(519, 182);
            this.btnProdMasVendidoXCategoria.Name = "btnProdMasVendidoXCategoria";
            this.btnProdMasVendidoXCategoria.Size = new System.Drawing.Size(200, 95);
            this.btnProdMasVendidoXCategoria.TabIndex = 3;
            this.btnProdMasVendidoXCategoria.Text = "Productos más vendidos por Categoría";
            this.btnProdMasVendidoXCategoria.UseVisualStyleBackColor = false;
            this.btnProdMasVendidoXCategoria.Click += new System.EventHandler(this.btnProdMasVendidoXCategoria_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnProdMasVendidoXCategoria);
            this.Controls.Add(this.btnVtasXVendedor);
            this.Controls.Add(this.btnStockCritico);
            this.Controls.Add(this.label1);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
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