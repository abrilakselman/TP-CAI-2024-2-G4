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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVta)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(129, 92);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(276, 28);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(13, 65);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(276, 28);
            this.comboBoxProducto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridViewVta);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.textBoxPrecioTotal);
            this.groupBox1.Controls.Add(this.textBoxPrecioUnit);
            this.groupBox1.Controls.Add(this.textBoxCant);
            this.groupBox1.Controls.Add(this.comboBoxProducto);
            this.groupBox1.Location = new System.Drawing.Point(49, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas para Cliente seleccionado";
            // 
            // dataGridViewVta
            // 
            this.dataGridViewVta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVta.Location = new System.Drawing.Point(35, 138);
            this.dataGridViewVta.Name = "dataGridViewVta";
            this.dataGridViewVta.RowHeadersWidth = 62;
            this.dataGridViewVta.RowTemplate.Height = 28;
            this.dataGridViewVta.Size = new System.Drawing.Size(799, 129);
            this.dataGridViewVta.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(738, 64);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 45);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxPrecioTotal
            // 
            this.textBoxPrecioTotal.Location = new System.Drawing.Point(602, 68);
            this.textBoxPrecioTotal.Name = "textBoxPrecioTotal";
            this.textBoxPrecioTotal.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioTotal.TabIndex = 4;
            // 
            // textBoxPrecioUnit
            // 
            this.textBoxPrecioUnit.Location = new System.Drawing.Point(463, 68);
            this.textBoxPrecioUnit.Name = "textBoxPrecioUnit";
            this.textBoxPrecioUnit.Size = new System.Drawing.Size(108, 26);
            this.textBoxPrecioUnit.TabIndex = 3;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(329, 68);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(108, 26);
            this.textBoxCant.TabIndex = 2;
            this.textBoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCant_KeyPres);
            this.textBoxCant.Leave += new System.EventHandler(this.textBoxCant_Leave);
            // 
            // btnGuardarVta
            // 
            this.btnGuardarVta.BackColor = System.Drawing.Color.Navy;
            this.btnGuardarVta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarVta.Location = new System.Drawing.Point(483, 482);
            this.btnGuardarVta.Name = "btnGuardarVta";
            this.btnGuardarVta.Size = new System.Drawing.Size(128, 63);
            this.btnGuardarVta.TabIndex = 3;
            this.btnGuardarVta.Text = "Guardar Venta";
            this.btnGuardarVta.UseVisualStyleBackColor = false;
            this.btnGuardarVta.Click += new System.EventHandler(this.btnGuardarVta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Haga click en el siguiente boton para ver comprobante:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Teal;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.Color.White;
            this.buttonVolver.Location = new System.Drawing.Point(801, 497);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(128, 48);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio Unitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio Total";
            // 
            // FormVentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarVta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCliente);
            this.Name = "FormVentaAlta";
            this.Text = "Nueva Venta";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}