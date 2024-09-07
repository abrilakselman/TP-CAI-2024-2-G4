namespace TemplateTPIntegrador
{
    partial class FormMensajeAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensajeAyuda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMjeAyuda = new System.Windows.Forms.Button();
            this.ImagenAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contactanos 24/7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "G4 esta con vos siempre.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "0800-555-ELECTRO (6648868)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quieres recibir asesoramiento personalizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "elctro_sa_argentina@yahoo.com.ar";
            // 
            // buttonMjeAyuda
            // 
            this.buttonMjeAyuda.Location = new System.Drawing.Point(198, 251);
            this.buttonMjeAyuda.Name = "buttonMjeAyuda";
            this.buttonMjeAyuda.Size = new System.Drawing.Size(135, 45);
            this.buttonMjeAyuda.TabIndex = 5;
            this.buttonMjeAyuda.Text = "Aceptar";
            this.buttonMjeAyuda.UseVisualStyleBackColor = true;
            this.buttonMjeAyuda.Click += new System.EventHandler(this.buttonMjeAyuda_Click);
            // 
            // ImagenAyuda
            // 
            this.ImagenAyuda.Image = ((System.Drawing.Image)(resources.GetObject("ImagenAyuda.Image")));
            this.ImagenAyuda.Location = new System.Drawing.Point(335, -1);
            this.ImagenAyuda.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.ImagenAyuda.Name = "ImagenAyuda";
            this.ImagenAyuda.Size = new System.Drawing.Size(185, 174);
            this.ImagenAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagenAyuda.TabIndex = 6;
            this.ImagenAyuda.TabStop = false;
            // 
            // FormMensajeAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 347);
            this.Controls.Add(this.ImagenAyuda);
            this.Controls.Add(this.buttonMjeAyuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMensajeAyuda";
            this.Text = "Ayuda";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMjeAyuda;
        private System.Windows.Forms.PictureBox ImagenAyuda;
    }
}