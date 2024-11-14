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
            this.comboBoxCliente.Location = new System.Drawing.Point(44, 31);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(185, 21);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(11, 14);
            this.comboBoxProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(185, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(33, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(586, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas para Cliente seleccionado";
            // 
            // dataGridViewVta
            // 
            this.dataGridViewVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVta.Location = new System.Drawing.Point(25, 62);
            this.dataGridViewVta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewVta.Name = "dataGridViewVta";
            this.dataGridViewVta.RowHeadersWidth = 62;
            this.dataGridViewVta.RowTemplate.Height = 28;
            this.dataGridViewVta.Size = new System.Drawing.Size(503, 84);
            this.dataGridViewVta.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(493, 14);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(64, 29);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(403, 17);
            this.textBoxPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(73, 20);
            this.textBoxPrecioTotal.TabIndex = 4;
            // 
            // textBoxPrecioUnit
            // 
            this.textBoxPrecioUnit.Location = new System.Drawing.Point(311, 16);
            this.textBoxPrecioUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrecioUnit.Name = "textBoxPrecioUnit";
            this.textBoxPrecioUnit.Size = new System.Drawing.Size(73, 20);
            this.textBoxPrecioUnit.TabIndex = 3;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(221, 16);
            this.textBoxCant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(73, 20);
            this.textBoxCant.TabIndex = 2;
            this.textBoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCant_KeyPres);
            this.textBoxCant.Leave += new System.EventHandler(this.textBoxCant_Leave);
            // 
            // btnGuardarVta
            // 
            this.btnGuardarVta.BackColor = System.Drawing.Color.Navy;
            this.btnGuardarVta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarVta.Location = new System.Drawing.Point(323, 275);
            this.btnGuardarVta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarVta.Name = "btnGuardarVta";
            this.btnGuardarVta.Size = new System.Drawing.Size(85, 41);
            this.btnGuardarVta.TabIndex = 3;
            this.btnGuardarVta.Text = "Guardar Venta";
            this.btnGuardarVta.UseVisualStyleBackColor = false;
            this.btnGuardarVta.Click += new System.EventHandler(this.btnGuardarVta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Haga click en el siguiente boton para ver comprobante:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Teal;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.Color.White;
            this.buttonVolver.Location = new System.Drawing.Point(535, 285);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(85, 31);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            // 
            // FormVentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 336);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarVta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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