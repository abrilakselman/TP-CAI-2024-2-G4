namespace TemplateTPIntegrador
{
    partial class FormListaCliente
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
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBajaCliente = new System.Windows.Forms.TextBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Clientes";
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(31, 62);
            this.dgvListaCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowHeadersWidth = 62;
            this.dgvListaCliente.RowTemplate.Height = 28;
            this.dgvListaCliente.Size = new System.Drawing.Size(506, 299);
            this.dgvListaCliente.TabIndex = 4;
            this.dgvListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cliente a Eliminar:";
            // 
            // textBoxBajaCliente
            // 
            this.textBoxBajaCliente.Location = new System.Drawing.Point(549, 263);
            this.textBoxBajaCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBajaCliente.Name = "textBoxBajaCliente";
            this.textBoxBajaCliente.Size = new System.Drawing.Size(155, 20);
            this.textBoxBajaCliente.TabIndex = 10;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(623, 162);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(104, 35);
            this.btnModificarCliente.TabIndex = 9;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.BackColor = System.Drawing.Color.Maroon;
            this.btnBajaCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBajaCliente.Location = new System.Drawing.Point(587, 300);
            this.btnBajaCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(104, 35);
            this.btnBajaCliente.TabIndex = 8;
            this.btnBajaCliente.Text = "Baja";
            this.btnBajaCliente.UseVisualStyleBackColor = false;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.Navy;
            this.btnAltaCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.ForeColor = System.Drawing.Color.White;
            this.btnAltaCliente.Location = new System.Drawing.Point(623, 105);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(104, 35);
            this.btnAltaCliente.TabIndex = 7;
            this.btnAltaCliente.Text = "Alta";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Haga click en el ID de la persona a dar de baja";
            // 
            // FormListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBajaCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnBajaCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.dgvListaCliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListaCliente";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FormListaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBajaCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Label label3;
    }
}