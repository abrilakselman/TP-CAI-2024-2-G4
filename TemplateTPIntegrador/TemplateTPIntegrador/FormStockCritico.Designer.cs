namespace TemplateTPIntegrador
{
    partial class FormStockCritico
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dgvListaProdStockCritico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdStockCritico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Stock Crítico:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(866, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación se listan todos los productos con un stock menor al 25% organizado" +
    " por categoría";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Blue;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.Color.White;
            this.buttonVolver.Location = new System.Drawing.Point(804, 440);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(154, 57);
            this.buttonVolver.TabIndex = 2;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // dgvListaProdStockCritico
            // 
            this.dgvListaProdStockCritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdStockCritico.Location = new System.Drawing.Point(63, 134);
            this.dgvListaProdStockCritico.Name = "dgvListaProdStockCritico";
            this.dgvListaProdStockCritico.RowHeadersWidth = 62;
            this.dgvListaProdStockCritico.RowTemplate.Height = 28;
            this.dgvListaProdStockCritico.Size = new System.Drawing.Size(711, 363);
            this.dgvListaProdStockCritico.TabIndex = 3;
            this.dgvListaProdStockCritico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProdStockCritico_CellContentClick);
            // 
            // FormStockCritico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 589);
            this.Controls.Add(this.dgvListaProdStockCritico);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStockCritico";
            this.Text = "Reporte de Stock Crítico";
            this.Load += new System.EventHandler(this.FormStockCritico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdStockCritico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dgvListaProdStockCritico;
    }
}