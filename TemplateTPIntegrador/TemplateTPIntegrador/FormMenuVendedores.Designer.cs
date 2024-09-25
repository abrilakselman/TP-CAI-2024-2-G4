namespace TemplateTPIntegrador
{
    partial class FormMenuVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuVendedores));
            this.panelMenuVendedores = new System.Windows.Forms.Panel();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panelMenuAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportesVendedor = new System.Windows.Forms.Button();
            this.btnVentasVendedor = new System.Windows.Forms.Button();
            this.panelMenuVendedores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVendedores
            // 
            this.panelMenuVendedores.Controls.Add(this.labelBienvenida);
            this.panelMenuVendedores.Location = new System.Drawing.Point(190, 3);
            this.panelMenuVendedores.Name = "panelMenuVendedores";
            this.panelMenuVendedores.Size = new System.Drawing.Size(883, 657);
            this.panelMenuVendedores.TabIndex = 10;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(40, 23);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(740, 49);
            this.labelBienvenida.TabIndex = 2;
            this.labelBienvenida.Text = "Bienvenido a la Aplicación ElectroHogar SA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Location = new System.Drawing.Point(4, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 220);
            this.panel1.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(23, 92);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(133, 33);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(20, 41);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(133, 33);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // panelMenuAdmin
            // 
            this.panelMenuAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenuAdmin.Controls.Add(this.pictureBox1);
            this.panelMenuAdmin.Controls.Add(this.btnReportesVendedor);
            this.panelMenuAdmin.Controls.Add(this.btnVentasVendedor);
            this.panelMenuAdmin.Location = new System.Drawing.Point(3, 3);
            this.panelMenuAdmin.Name = "panelMenuAdmin";
            this.panelMenuAdmin.Size = new System.Drawing.Size(181, 437);
            this.panelMenuAdmin.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportesVendedor
            // 
            this.btnReportesVendedor.Location = new System.Drawing.Point(24, 321);
            this.btnReportesVendedor.Name = "btnReportesVendedor";
            this.btnReportesVendedor.Size = new System.Drawing.Size(133, 33);
            this.btnReportesVendedor.TabIndex = 4;
            this.btnReportesVendedor.Text = "Reportes";
            this.btnReportesVendedor.UseVisualStyleBackColor = true;
            this.btnReportesVendedor.Click += new System.EventHandler(this.btnReportesVendedor_Click);
            // 
            // btnVentasVendedor
            // 
            this.btnVentasVendedor.Location = new System.Drawing.Point(23, 241);
            this.btnVentasVendedor.Name = "btnVentasVendedor";
            this.btnVentasVendedor.Size = new System.Drawing.Size(134, 33);
            this.btnVentasVendedor.TabIndex = 2;
            this.btnVentasVendedor.Text = "Ventas";
            this.btnVentasVendedor.UseVisualStyleBackColor = true;
            // 
            // FormMenuVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 665);
            this.Controls.Add(this.panelMenuVendedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAdmin);
            this.Name = "FormMenuVendedores";
            this.Text = "Menu";
            this.panelMenuVendedores.ResumeLayout(false);
            this.panelMenuVendedores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVendedores;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panelMenuAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportesVendedor;
        private System.Windows.Forms.Button btnVentasVendedor;
    }
}