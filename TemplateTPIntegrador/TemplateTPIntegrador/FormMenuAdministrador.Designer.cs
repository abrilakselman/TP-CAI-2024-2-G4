namespace TemplateTPIntegrador
{
    partial class FormMenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdministrador));
            this.panelMenuAdmin = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelMsgStockCritico = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBoxStockCritico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuAdmin
            // 
            this.panelMenuAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenuAdmin.Controls.Add(this.btnCliente);
            this.panelMenuAdmin.Controls.Add(this.pictureBox1);
            this.panelMenuAdmin.Controls.Add(this.btnReportes);
            this.panelMenuAdmin.Controls.Add(this.btnProducto);
            this.panelMenuAdmin.Controls.Add(this.btnProveedores);
            this.panelMenuAdmin.Controls.Add(this.btnUsuario);
            this.panelMenuAdmin.Location = new System.Drawing.Point(1, 2);
            this.panelMenuAdmin.Name = "panelMenuAdmin";
            this.panelMenuAdmin.Size = new System.Drawing.Size(181, 437);
            this.panelMenuAdmin.TabIndex = 0;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(23, 310);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 33);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(22, 358);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(133, 33);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(23, 271);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 33);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(23, 232);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(133, 33);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(22, 193);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(133, 33);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 236);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 119);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(20, 65);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(133, 33);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
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
            // labelMsgStockCritico
            // 
            this.labelMsgStockCritico.AutoSize = true;
            this.labelMsgStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgStockCritico.Location = new System.Drawing.Point(157, 131);
            this.labelMsgStockCritico.Name = "labelMsgStockCritico";
            this.labelMsgStockCritico.Size = new System.Drawing.Size(297, 29);
            this.labelMsgStockCritico.TabIndex = 3;
            this.labelMsgStockCritico.Text = "productos con stock crítico";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.textBoxStockCritico);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.labelMsgStockCritico);
            this.panelMenu.Controls.Add(this.labelBienvenida);
            this.panelMenu.Location = new System.Drawing.Point(177, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1726, 673);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // textBoxStockCritico
            // 
            this.textBoxStockCritico.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStockCritico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockCritico.Location = new System.Drawing.Point(114, 129);
            this.textBoxStockCritico.Name = "textBoxStockCritico";
            this.textBoxStockCritico.Size = new System.Drawing.Size(44, 28);
            this.textBoxStockCritico.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hay";
            // 
            // FormMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1915, 678);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAdmin);
            this.Name = "FormMenuAdministrador";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenuAdministrador_Load);
            this.panelMenuAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuAdmin;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelMsgStockCritico;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox textBoxStockCritico;
        private System.Windows.Forms.Label label1;
    }
}