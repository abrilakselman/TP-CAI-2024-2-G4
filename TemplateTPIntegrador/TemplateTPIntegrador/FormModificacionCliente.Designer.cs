namespace TemplateTPIntegrador
{
    partial class FormModificacionCliente
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
            this.labelTituloM = new System.Windows.Forms.Label();
            this.labelEmailM = new System.Windows.Forms.Label();
            this.labeltelM = new System.Windows.Forms.Label();
            this.labelDireccM = new System.Windows.Forms.Label();
            this.textBoxEmailM = new System.Windows.Forms.TextBox();
            this.textBoxDireccM = new System.Windows.Forms.TextBox();
            this.textBoxTelM = new System.Windows.Forms.TextBox();
            this.buttonAceptarM = new System.Windows.Forms.Button();
            this.buttonVolverM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloM
            // 
            this.labelTituloM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTituloM.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloM.ForeColor = System.Drawing.Color.White;
            this.labelTituloM.Location = new System.Drawing.Point(12, 18);
            this.labelTituloM.Name = "labelTituloM";
            this.labelTituloM.Size = new System.Drawing.Size(781, 40);
            this.labelTituloM.TabIndex = 2;
            this.labelTituloM.Text = "Modificacion de Cliente";
            // 
            // labelEmailM
            // 
            this.labelEmailM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailM.ForeColor = System.Drawing.Color.Black;
            this.labelEmailM.Location = new System.Drawing.Point(12, 93);
            this.labelEmailM.Name = "labelEmailM";
            this.labelEmailM.Size = new System.Drawing.Size(139, 28);
            this.labelEmailM.TabIndex = 3;
            this.labelEmailM.Text = "Email";
            // 
            // labeltelM
            // 
            this.labeltelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelM.Location = new System.Drawing.Point(15, 299);
            this.labeltelM.Name = "labeltelM";
            this.labeltelM.Size = new System.Drawing.Size(83, 22);
            this.labeltelM.TabIndex = 4;
            this.labeltelM.Text = "Teléfono";
            // 
            // labelDireccM
            // 
            this.labelDireccM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccM.Location = new System.Drawing.Point(12, 201);
            this.labelDireccM.Name = "labelDireccM";
            this.labelDireccM.Size = new System.Drawing.Size(112, 28);
            this.labelDireccM.TabIndex = 5;
            this.labelDireccM.Text = "Dirección";
            this.labelDireccM.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxEmailM
            // 
            this.textBoxEmailM.Location = new System.Drawing.Point(12, 111);
            this.textBoxEmailM.Name = "textBoxEmailM";
            this.textBoxEmailM.Size = new System.Drawing.Size(204, 20);
            this.textBoxEmailM.TabIndex = 6;
            // 
            // textBoxDireccM
            // 
            this.textBoxDireccM.Location = new System.Drawing.Point(12, 220);
            this.textBoxDireccM.Name = "textBoxDireccM";
            this.textBoxDireccM.Size = new System.Drawing.Size(207, 20);
            this.textBoxDireccM.TabIndex = 7;
            // 
            // textBoxTelM
            // 
            this.textBoxTelM.Location = new System.Drawing.Point(12, 315);
            this.textBoxTelM.Name = "textBoxTelM";
            this.textBoxTelM.Size = new System.Drawing.Size(207, 20);
            this.textBoxTelM.TabIndex = 8;
            // 
            // buttonAceptarM
            // 
            this.buttonAceptarM.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAceptarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptarM.ForeColor = System.Drawing.Color.White;
            this.buttonAceptarM.Location = new System.Drawing.Point(389, 334);
            this.buttonAceptarM.Name = "buttonAceptarM";
            this.buttonAceptarM.Size = new System.Drawing.Size(136, 49);
            this.buttonAceptarM.TabIndex = 9;
            this.buttonAceptarM.Text = "Aceptar";
            this.buttonAceptarM.UseVisualStyleBackColor = false;
            // 
            // buttonVolverM
            // 
            this.buttonVolverM.BackColor = System.Drawing.Color.Teal;
            this.buttonVolverM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverM.ForeColor = System.Drawing.Color.White;
            this.buttonVolverM.Location = new System.Drawing.Point(531, 334);
            this.buttonVolverM.Name = "buttonVolverM";
            this.buttonVolverM.Size = new System.Drawing.Size(136, 49);
            this.buttonVolverM.TabIndex = 10;
            this.buttonVolverM.Text = "Volver";
            this.buttonVolverM.UseVisualStyleBackColor = false;
            // 
            // FormModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 395);
            this.Controls.Add(this.buttonVolverM);
            this.Controls.Add(this.buttonAceptarM);
            this.Controls.Add(this.textBoxTelM);
            this.Controls.Add(this.textBoxDireccM);
            this.Controls.Add(this.textBoxEmailM);
            this.Controls.Add(this.labelDireccM);
            this.Controls.Add(this.labeltelM);
            this.Controls.Add(this.labelEmailM);
            this.Controls.Add(this.labelTituloM);
            this.Name = "FormModificacionCliente";
            this.Text = "FormModificacionCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloM;
        private System.Windows.Forms.Label labelEmailM;
        private System.Windows.Forms.Label labeltelM;
        private System.Windows.Forms.Label labelDireccM;
        private System.Windows.Forms.TextBox textBoxEmailM;
        private System.Windows.Forms.TextBox textBoxDireccM;
        private System.Windows.Forms.TextBox textBoxTelM;
        private System.Windows.Forms.Button buttonAceptarM;
        private System.Windows.Forms.Button buttonVolverM;
    }
}