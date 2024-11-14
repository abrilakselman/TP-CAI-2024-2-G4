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
            this.textBoxBajaUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
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
            this.dgvListaUsuario.Size = new System.Drawing.Size(807, 632);
            this.dgvListaUsuario.TabIndex = 1;
            this.dgvListaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuario_CellContentClick);
            // 
            // btnAltaUser
            // 
            this.btnAltaUser.BackColor = System.Drawing.Color.Navy;
            this.btnAltaUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltaUser.Location = new System.Drawing.Point(845, 232);
            this.btnAltaUser.Name = "btnAltaUser";
            this.btnAltaUser.Size = new System.Drawing.Size(156, 54);
            this.btnAltaUser.TabIndex = 2;
            this.btnAltaUser.Text = "Alta";
            this.btnAltaUser.UseVisualStyleBackColor = false;
            this.btnAltaUser.Click += new System.EventHandler(this.btnAltaUser_Click);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btnBajaUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBajaUsuario.Location = new System.Drawing.Point(845, 474);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(156, 54);
            this.btnBajaUsuario.TabIndex = 3;
            this.btnBajaUsuario.Text = "Baja";
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificarUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUser.ForeColor = System.Drawing.Color.White;
            this.btnModificarUser.Location = new System.Drawing.Point(845, 292);
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(156, 54);
            this.btnModificarUser.TabIndex = 4;
            this.btnModificarUser.Text = "Modificar";
            this.btnModificarUser.UseVisualStyleBackColor = false;
            this.btnModificarUser.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textBoxBajaUser
            // 
            this.textBoxBajaUser.Location = new System.Drawing.Point(845, 417);
            this.textBoxBajaUser.Name = "textBoxBajaUser";
            this.textBoxBajaUser.Size = new System.Drawing.Size(230, 26);
            this.textBoxBajaUser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario a Eliminar:";
            // 
            // FormListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBajaUser);
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
        private System.Windows.Forms.TextBox textBoxBajaUser;
        private System.Windows.Forms.Label label2;
    }
}