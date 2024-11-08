namespace TemplateTPIntegrador
{
    partial class FormReactivarCuenta
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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxPassConfirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonActivar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApeUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblNomUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMaxUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMinUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblInstruccionesRegistrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(267, 146);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(232, 26);
            this.textBoxPass.TabIndex = 0;
            // 
            // textBoxPassConfirmar
            // 
            this.textBoxPassConfirmar.Location = new System.Drawing.Point(267, 230);
            this.textBoxPassConfirmar.Name = "textBoxPassConfirmar";
            this.textBoxPassConfirmar.Size = new System.Drawing.Size(232, 26);
            this.textBoxPassConfirmar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repetir Nueva Contraseña";
            // 
            // buttonActivar
            // 
            this.buttonActivar.Location = new System.Drawing.Point(190, 334);
            this.buttonActivar.Name = "buttonActivar";
            this.buttonActivar.Size = new System.Drawing.Size(155, 49);
            this.buttonActivar.TabIndex = 4;
            this.buttonActivar.Text = "Activar";
            this.buttonActivar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(409, 334);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(155, 49);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reactivacion";
            // 
            // lblApeUsuarioRegistrar
            // 
            this.lblApeUsuarioRegistrar.AutoSize = true;
            this.lblApeUsuarioRegistrar.Location = new System.Drawing.Point(522, 278);
            this.lblApeUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApeUsuarioRegistrar.Name = "lblApeUsuarioRegistrar";
            this.lblApeUsuarioRegistrar.Size = new System.Drawing.Size(300, 24);
            this.lblApeUsuarioRegistrar.TabIndex = 75;
            this.lblApeUsuarioRegistrar.Text = "No debe contener el apellido del usuario";
            this.lblApeUsuarioRegistrar.UseCompatibleTextRendering = true;
            // 
            // lblNomUsuarioRegistrar
            // 
            this.lblNomUsuarioRegistrar.AutoSize = true;
            this.lblNomUsuarioRegistrar.Location = new System.Drawing.Point(522, 239);
            this.lblNomUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsuarioRegistrar.Name = "lblNomUsuarioRegistrar";
            this.lblNomUsuarioRegistrar.Size = new System.Drawing.Size(291, 20);
            this.lblNomUsuarioRegistrar.TabIndex = 74;
            this.lblNomUsuarioRegistrar.Text = "No debe contener el nombre del usuario";
            // 
            // lblMaxUsuarioRegistrar
            // 
            this.lblMaxUsuarioRegistrar.AutoSize = true;
            this.lblMaxUsuarioRegistrar.Location = new System.Drawing.Point(522, 201);
            this.lblMaxUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxUsuarioRegistrar.Name = "lblMaxUsuarioRegistrar";
            this.lblMaxUsuarioRegistrar.Size = new System.Drawing.Size(290, 20);
            this.lblMaxUsuarioRegistrar.TabIndex = 73;
            this.lblMaxUsuarioRegistrar.Text = "Debe contener menos de 15 caracteres";
            // 
            // lblMinUsuarioRegistrar
            // 
            this.lblMinUsuarioRegistrar.AutoSize = true;
            this.lblMinUsuarioRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinUsuarioRegistrar.Location = new System.Drawing.Point(522, 162);
            this.lblMinUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinUsuarioRegistrar.Name = "lblMinUsuarioRegistrar";
            this.lblMinUsuarioRegistrar.Size = new System.Drawing.Size(263, 20);
            this.lblMinUsuarioRegistrar.TabIndex = 72;
            this.lblMinUsuarioRegistrar.Text = "Debe contener más de 8 caracteres";
            // 
            // lblInstruccionesRegistrar
            // 
            this.lblInstruccionesRegistrar.AutoSize = true;
            this.lblInstruccionesRegistrar.Location = new System.Drawing.Point(522, 124);
            this.lblInstruccionesRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruccionesRegistrar.Name = "lblInstruccionesRegistrar";
            this.lblInstruccionesRegistrar.Size = new System.Drawing.Size(316, 20);
            this.lblInstruccionesRegistrar.TabIndex = 71;
            this.lblInstruccionesRegistrar.Text = "Tenga en cuenta que el nombre de usuario:";
            // 
            // FormReactivarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.lblApeUsuarioRegistrar);
            this.Controls.Add(this.lblNomUsuarioRegistrar);
            this.Controls.Add(this.lblMaxUsuarioRegistrar);
            this.Controls.Add(this.lblMinUsuarioRegistrar);
            this.Controls.Add(this.lblInstruccionesRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonActivar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassConfirmar);
            this.Controls.Add(this.textBoxPass);
            this.Name = "FormReactivarCuenta";
            this.Text = "Reactivar Cuenta";
            this.Load += new System.EventHandler(this.FormReactivarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxPassConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonActivar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApeUsuarioRegistrar;
        private System.Windows.Forms.Label lblNomUsuarioRegistrar;
        private System.Windows.Forms.Label lblMaxUsuarioRegistrar;
        private System.Windows.Forms.Label lblMinUsuarioRegistrar;
        private System.Windows.Forms.Label lblInstruccionesRegistrar;
    }
}