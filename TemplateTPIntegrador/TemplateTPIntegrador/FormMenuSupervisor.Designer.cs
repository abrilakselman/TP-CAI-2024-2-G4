﻿namespace TemplateTPIntegrador
{
    partial class FormMenuSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuSupervisor));
            this.panelMenuSupervisor = new System.Windows.Forms.Panel();
            this.labelMsgStockCritico = new System.Windows.Forms.Label();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panelMenuAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportesSupervisor = new System.Windows.Forms.Button();
            this.btnDevolucionesSupervisor = new System.Windows.Forms.Button();
            this.btnProductoSupervisor = new System.Windows.Forms.Button();
            this.panelMenuSupervisor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuSupervisor
            // 
            this.panelMenuSupervisor.Controls.Add(this.labelMsgStockCritico);
            this.panelMenuSupervisor.Controls.Add(this.labelBienvenida);
            this.panelMenuSupervisor.Location = new System.Drawing.Point(189, 2);
            this.panelMenuSupervisor.Name = "panelMenuSupervisor";
            this.panelMenuSupervisor.Size = new System.Drawing.Size(931, 657);
            this.panelMenuSupervisor.TabIndex = 7;
            // 
            // labelMsgStockCritico
            // 
            this.labelMsgStockCritico.AutoSize = true;
            this.labelMsgStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgStockCritico.Location = new System.Drawing.Point(45, 129);
            this.labelMsgStockCritico.Name = "labelMsgStockCritico";
            this.labelMsgStockCritico.Size = new System.Drawing.Size(401, 29);
            this.labelMsgStockCritico.TabIndex = 3;
            this.labelMsgStockCritico.Text = "Hay XXX productos con stock crítico";
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
            this.panel1.Location = new System.Drawing.Point(3, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 220);
            this.panel1.TabIndex = 6;
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
            this.panelMenuAdmin.Controls.Add(this.btnReportesSupervisor);
            this.panelMenuAdmin.Controls.Add(this.btnDevolucionesSupervisor);
            this.panelMenuAdmin.Controls.Add(this.btnProductoSupervisor);
            this.panelMenuAdmin.Location = new System.Drawing.Point(2, 2);
            this.panelMenuAdmin.Name = "panelMenuAdmin";
            this.panelMenuAdmin.Size = new System.Drawing.Size(181, 437);
            this.panelMenuAdmin.TabIndex = 5;
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
            // btnReportesSupervisor
            // 
            this.btnReportesSupervisor.Location = new System.Drawing.Point(24, 321);
            this.btnReportesSupervisor.Name = "btnReportesSupervisor";
            this.btnReportesSupervisor.Size = new System.Drawing.Size(133, 33);
            this.btnReportesSupervisor.TabIndex = 4;
            this.btnReportesSupervisor.Text = "Reportes";
            this.btnReportesSupervisor.UseVisualStyleBackColor = true;
            this.btnReportesSupervisor.Click += new System.EventHandler(this.btnReportesSupervisor_Click);
            // 
            // btnDevolucionesSupervisor
            // 
            this.btnDevolucionesSupervisor.Location = new System.Drawing.Point(24, 281);
            this.btnDevolucionesSupervisor.Name = "btnDevolucionesSupervisor";
            this.btnDevolucionesSupervisor.Size = new System.Drawing.Size(133, 33);
            this.btnDevolucionesSupervisor.TabIndex = 3;
            this.btnDevolucionesSupervisor.Text = "Devolucion";
            this.btnDevolucionesSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnProductoSupervisor
            // 
            this.btnProductoSupervisor.Location = new System.Drawing.Point(23, 241);
            this.btnProductoSupervisor.Name = "btnProductoSupervisor";
            this.btnProductoSupervisor.Size = new System.Drawing.Size(134, 33);
            this.btnProductoSupervisor.TabIndex = 2;
            this.btnProductoSupervisor.Text = "Productos";
            this.btnProductoSupervisor.UseVisualStyleBackColor = true;
            // 
            // FormMenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 662);
            this.Controls.Add(this.panelMenuSupervisor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAdmin);
            this.Name = "FormMenuSupervisor";
            this.Text = "Menu";
            this.panelMenuSupervisor.ResumeLayout(false);
            this.panelMenuSupervisor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuSupervisor;
        private System.Windows.Forms.Label labelMsgStockCritico;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panelMenuAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportesSupervisor;
        private System.Windows.Forms.Button btnDevolucionesSupervisor;
        private System.Windows.Forms.Button btnProductoSupervisor;
    }
}