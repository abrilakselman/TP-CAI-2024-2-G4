namespace TemplateTPIntegrador
{
    partial class FormListaUsuario
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
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.btnAltaUser = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnModificarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuario";
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.AllowUserToOrderColumns = true;
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Location = new System.Drawing.Point(2, 83);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.RowHeadersWidth = 62;
            this.dgvListaUsuario.RowTemplate.Height = 28;
            this.dgvListaUsuario.Size = new System.Drawing.Size(1046, 632);
            this.dgvListaUsuario.TabIndex = 1;
            // 
            // btnAltaUser
            // 
            this.btnAltaUser.Location = new System.Drawing.Point(1073, 209);
            this.btnAltaUser.Name = "btnAltaUser";
            this.btnAltaUser.Size = new System.Drawing.Size(156, 54);
            this.btnAltaUser.TabIndex = 2;
            this.btnAltaUser.Text = "Alta";
            this.btnAltaUser.UseVisualStyleBackColor = true;
            this.btnAltaUser.Click += new System.EventHandler(this.btnAltaUser_Click);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Location = new System.Drawing.Point(1073, 300);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(156, 54);
            this.btnBajaUsuario.TabIndex = 3;
            this.btnBajaUsuario.Text = "Baja";
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.Location = new System.Drawing.Point(1073, 394);
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(156, 54);
            this.btnModificarUser.TabIndex = 4;
            this.btnModificarUser.Text = "Modificar";
            this.btnModificarUser.UseVisualStyleBackColor = true;
            this.btnModificarUser.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 739);
            this.Controls.Add(this.btnModificarUser);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.btnAltaUser);
            this.Controls.Add(this.dgvListaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormListaUsuario";
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.FormListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.Button btnAltaUser;
        private System.Windows.Forms.Button btnBajaUsuario;
        private System.Windows.Forms.Button btnModificarUser;
    }
}