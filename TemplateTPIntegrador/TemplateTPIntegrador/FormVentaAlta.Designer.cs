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
            this.btnGuardarVta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
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
            this.groupBox1.Size = new System.Drawing.Size(879, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas para Cliente seleccionado";
            // 
            // dataGridViewVta
            // 
            this.dataGridViewVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVta.Location = new System.Drawing.Point(37, 95);
            this.dataGridViewVta.Name = "dataGridViewVta";
            this.dataGridViewVta.RowHeadersWidth = 62;
            this.dataGridViewVta.RowTemplate.Height = 28;
            this.dataGridViewVta.Size = new System.Drawing.Size(754, 130);
            this.dataGridViewVta.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(740, 22);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 45);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(605, 26);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioTotal.TabIndex = 4;
            // 
            // textBoxPrecioUnit
            // 
            this.textBoxPrecioUnit.Location = new System.Drawing.Point(467, 25);
            this.textBoxPrecioUnit.Name = "textBoxPrecioUnit";
            this.textBoxPrecioUnit.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioUnit.TabIndex = 3;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(331, 25);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(108, 26);
            this.textBoxCant.TabIndex = 2;
            this.textBoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCant_KeyPres);
            this.textBoxCant.Leave += new System.EventHandler(this.textBoxCant_Leave);
            // 
            // btnGuardarVta
            // 
            this.btnGuardarVta.Location = new System.Drawing.Point(485, 438);
            this.btnGuardarVta.Name = "btnGuardarVta";
            this.btnGuardarVta.Size = new System.Drawing.Size(127, 48);
            this.btnGuardarVta.TabIndex = 3;
            this.btnGuardarVta.Text = "Guardar Venta";
            this.btnGuardarVta.UseVisualStyleBackColor = true;
            this.btnGuardarVta.Click += new System.EventHandler(this.btnGuardarVta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Haga click en el siguiente boton para ver comprobante:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(802, 438);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(127, 48);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // FormVentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 517);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarVta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCliente);
            this.Name = "FormVentaAlta";
            this.Text = "FormVentaAlta";
            this.Load += new System.EventHandler(this.FormVentaAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnGuardarVta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
    }
}