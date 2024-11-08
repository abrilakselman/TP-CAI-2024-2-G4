namespace TemplateTPIntegrador
{
    partial class FormCambiarContraseña
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassConfirmar = new System.Windows.Forms.TextBox();
            this.textBoxPassNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContraseñaActual = new System.Windows.Forms.TextBox();
            this.labelErrorContraseñaIgual = new System.Windows.Forms.Label();
            this.labelErrorContraseñaActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(468, 344);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(155, 49);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(249, 344);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(155, 49);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repetir Nueva Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nueva Contraseña";
            // 
            // textBoxPassConfirmar
            // 
            this.textBoxPassConfirmar.Location = new System.Drawing.Point(317, 235);
            this.textBoxPassConfirmar.Name = "textBoxPassConfirmar";
            this.textBoxPassConfirmar.Size = new System.Drawing.Size(232, 26);
            this.textBoxPassConfirmar.TabIndex = 8;
            // 
            // textBoxPassNueva
            // 
            this.textBoxPassNueva.Location = new System.Drawing.Point(317, 166);
            this.textBoxPassNueva.Name = "textBoxPassNueva";
            this.textBoxPassNueva.Size = new System.Drawing.Size(232, 26);
            this.textBoxPassNueva.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña Actual";
            // 
            // textBoxContraseñaActual
            // 
            this.textBoxContraseñaActual.Location = new System.Drawing.Point(317, 83);
            this.textBoxContraseñaActual.Name = "textBoxContraseñaActual";
            this.textBoxContraseñaActual.Size = new System.Drawing.Size(232, 26);
            this.textBoxContraseñaActual.TabIndex = 13;
            // 
            // labelErrorContraseñaIgual
            // 
            this.labelErrorContraseñaIgual.AutoSize = true;
            this.labelErrorContraseñaIgual.Location = new System.Drawing.Point(109, 278);
            this.labelErrorContraseñaIgual.Name = "labelErrorContraseñaIgual";
            this.labelErrorContraseñaIgual.Size = new System.Drawing.Size(0, 20);
            this.labelErrorContraseñaIgual.TabIndex = 15;
            // 
            // labelErrorContraseñaActual
            // 
            this.labelErrorContraseñaActual.AutoSize = true;
            this.labelErrorContraseñaActual.Location = new System.Drawing.Point(109, 120);
            this.labelErrorContraseñaActual.Name = "labelErrorContraseñaActual";
            this.labelErrorContraseñaActual.Size = new System.Drawing.Size(0, 20);
            this.labelErrorContraseñaActual.TabIndex = 16;
            // 
            // FormCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.labelErrorContraseñaActual);
            this.Controls.Add(this.labelErrorContraseñaIgual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxContraseñaActual);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassConfirmar);
            this.Controls.Add(this.textBoxPassNueva);
            this.Name = "FormCambiarContraseña";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FormCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassConfirmar;
        private System.Windows.Forms.TextBox textBoxPassNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContraseñaActual;
        private System.Windows.Forms.Label labelErrorContraseñaIgual;
        private System.Windows.Forms.Label labelErrorContraseñaActual;
    }
}