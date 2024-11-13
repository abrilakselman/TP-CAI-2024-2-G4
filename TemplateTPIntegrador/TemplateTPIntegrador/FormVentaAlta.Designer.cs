namespace TemplateTPIntegrador
{
    partial class FormVentaAlta
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
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVta = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxPrecioTotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecioUnit = new System.Windows.Forms.TextBox();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVta)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(66, 48);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(275, 28);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(16, 22);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(275, 28);
            this.comboBoxProducto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewVta);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.textBoxPrecioTotal);
            this.groupBox1.Controls.Add(this.textBoxPrecioUnit);
            this.groupBox1.Controls.Add(this.textBoxCant);
            this.groupBox1.Controls.Add(this.comboBoxProducto);
            this.groupBox1.Location = new System.Drawing.Point(50, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridViewVta
            // 
            this.dataGridViewVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVta.Location = new System.Drawing.Point(37, 95);
            this.dataGridViewVta.Name = "dataGridViewVta";
            this.dataGridViewVta.RowHeadersWidth = 62;
            this.dataGridViewVta.RowTemplate.Height = 28;
            this.dataGridViewVta.Size = new System.Drawing.Size(754, 181);
            this.dataGridViewVta.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(852, 30);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 45);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(708, 22);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioTotal.TabIndex = 4;
            // 
            // textBoxPrecioUnit
            // 
            this.textBoxPrecioUnit.Location = new System.Drawing.Point(563, 22);
            this.textBoxPrecioUnit.Name = "textBoxPrecioUnit";
            this.textBoxPrecioUnit.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioUnit.TabIndex = 3;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(394, 25);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(108, 26);
            this.textBoxCant.TabIndex = 2;
            this.textBoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCant_KeyPres);
            this.textBoxCant.Leave += new System.EventHandler(this.textBoxCant_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(213, 449);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 48);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormVentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCliente);
            this.Name = "FormVentaAlta";
            this.Text = "FormVentaAlta";
            this.Load += new System.EventHandler(this.FormVentaAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewVta;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxPrecioTotal;
        private System.Windows.Forms.TextBox textBoxPrecioUnit;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Button btnAceptar;
    }
}