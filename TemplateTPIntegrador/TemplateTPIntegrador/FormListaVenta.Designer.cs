namespace TemplateTPIntegrador
{
    partial class FormListaVenta
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
            this.textBoxBaja = new System.Windows.Forms.TextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaVtaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVtaCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBaja
            // 
            this.textBoxBaja.Location = new System.Drawing.Point(13, 33);
            this.textBoxBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBaja.Name = "textBoxBaja";
            this.textBoxBaja.Size = new System.Drawing.Size(131, 20);
            this.textBoxBaja.TabIndex = 15;
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.Maroon;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(23, 63);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(79, 35);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ventas catalogadas por Cliente";
            // 
            // dgvListaVtaCliente
            // 
            this.dgvListaVtaCliente.AllowUserToOrderColumns = true;
            this.dgvListaVtaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVtaCliente.Location = new System.Drawing.Point(8, 125);
            this.dgvListaVtaCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaVtaCliente.Name = "dgvListaVtaCliente";
            this.dgvListaVtaCliente.RowHeadersWidth = 62;
            this.dgvListaVtaCliente.RowTemplate.Height = 28;
            this.dgvListaVtaCliente.Size = new System.Drawing.Size(545, 211);
            this.dgvListaVtaCliente.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBaja);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Location = new System.Drawing.Point(561, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(161, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta a Eliminar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // buttonAlta
            // 
            this.buttonAlta.BackColor = System.Drawing.Color.Navy;
            this.buttonAlta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlta.ForeColor = System.Drawing.Color.White;
            this.buttonAlta.Location = new System.Drawing.Point(585, 150);
            this.buttonAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(86, 30);
            this.buttonAlta.TabIndex = 20;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = false;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(428, 67);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(69, 26);
            this.buttonOK.TabIndex = 19;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(265, 75);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(125, 21);
            this.comboBoxCliente.TabIndex = 18;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seleccione un Cliente para ver Venta:";
            // 
            // FormListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaVtaCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListaVenta";
            this.Text = "Lista de Ventas";
            this.Load += new System.EventHandler(this.FormListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVtaCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaVtaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label3;
    }
}