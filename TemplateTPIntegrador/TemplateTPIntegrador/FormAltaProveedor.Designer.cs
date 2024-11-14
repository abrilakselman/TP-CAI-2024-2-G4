namespace TemplateTPIntegrador
{
    partial class FormAltaProveedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaProveedor));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCuitIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbCuitCorrecto = new System.Windows.Forms.PictureBox();
            this.pbEmailIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbEmailCorrecto = new System.Windows.Forms.PictureBox();
            this.pbApellidoCorrecto = new System.Windows.Forms.PictureBox();
            this.pbApellidoIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbNomCorrecto = new System.Windows.Forms.PictureBox();
            this.pbNomIncorrecto = new System.Windows.Forms.PictureBox();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuitIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuitCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNomCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNomIncorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(124, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(206, 26);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(124, 115);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(206, 26);
            this.textBoxApellido.TabIndex = 2;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(516, 48);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 26);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CUIT:";
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.Location = new System.Drawing.Point(516, 109);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.Size = new System.Drawing.Size(206, 26);
            this.textBoxCUIT.TabIndex = 6;
            this.textBoxCUIT.TextChanged += new System.EventHandler(this.textBoxCUIT_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbCuitIncorrecto);
            this.groupBox1.Controls.Add(this.pbCuitCorrecto);
            this.groupBox1.Controls.Add(this.pbEmailIncorrecto);
            this.groupBox1.Controls.Add(this.pbEmailCorrecto);
            this.groupBox1.Controls.Add(this.pbApellidoCorrecto);
            this.groupBox1.Controls.Add(this.pbApellidoIncorrecto);
            this.groupBox1.Controls.Add(this.pbNomCorrecto);
            this.groupBox1.Controls.Add(this.pbNomIncorrecto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCUIT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(39, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Nuevo Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbCuitIncorrecto
            // 
            this.pbCuitIncorrecto.ErrorImage = null;
            this.pbCuitIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbCuitIncorrecto.Image")));
            this.pbCuitIncorrecto.Location = new System.Drawing.Point(730, 102);
            this.pbCuitIncorrecto.Name = "pbCuitIncorrecto";
            this.pbCuitIncorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbCuitIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCuitIncorrecto.TabIndex = 48;
            this.pbCuitIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCuitIncorrecto, "El CUIT no puede estar vacio ni contener letras.\r\nTiene que tener 11 digitos posi" +
        "tivos.");
            // 
            // pbCuitCorrecto
            // 
            this.pbCuitCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbCuitCorrecto.Image")));
            this.pbCuitCorrecto.Location = new System.Drawing.Point(729, 102);
            this.pbCuitCorrecto.Name = "pbCuitCorrecto";
            this.pbCuitCorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbCuitCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCuitCorrecto.TabIndex = 47;
            this.pbCuitCorrecto.TabStop = false;
            // 
            // pbEmailIncorrecto
            // 
            this.pbEmailIncorrecto.ErrorImage = null;
            this.pbEmailIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailIncorrecto.Image")));
            this.pbEmailIncorrecto.Location = new System.Drawing.Point(730, 35);
            this.pbEmailIncorrecto.Name = "pbEmailIncorrecto";
            this.pbEmailIncorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbEmailIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmailIncorrecto.TabIndex = 46;
            this.pbEmailIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbEmailIncorrecto, "El email no puede ser vacio.\r\nDebe contener @ y ser de extensión \".com\"");
            // 
            // pbEmailCorrecto
            // 
            this.pbEmailCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailCorrecto.Image")));
            this.pbEmailCorrecto.Location = new System.Drawing.Point(729, 35);
            this.pbEmailCorrecto.Name = "pbEmailCorrecto";
            this.pbEmailCorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbEmailCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmailCorrecto.TabIndex = 45;
            this.pbEmailCorrecto.TabStop = false;
            // 
            // pbApellidoCorrecto
            // 
            this.pbApellidoCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbApellidoCorrecto.ErrorImage")));
            this.pbApellidoCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbApellidoCorrecto.Image")));
            this.pbApellidoCorrecto.Location = new System.Drawing.Point(351, 105);
            this.pbApellidoCorrecto.Name = "pbApellidoCorrecto";
            this.pbApellidoCorrecto.Size = new System.Drawing.Size(39, 38);
            this.pbApellidoCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellidoCorrecto.TabIndex = 44;
            this.pbApellidoCorrecto.TabStop = false;
            // 
            // pbApellidoIncorrecto
            // 
            this.pbApellidoIncorrecto.ErrorImage = null;
            this.pbApellidoIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbApellidoIncorrecto.Image")));
            this.pbApellidoIncorrecto.Location = new System.Drawing.Point(350, 105);
            this.pbApellidoIncorrecto.Name = "pbApellidoIncorrecto";
            this.pbApellidoIncorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbApellidoIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellidoIncorrecto.TabIndex = 43;
            this.pbApellidoIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbApellidoIncorrecto, "El apellido debe tener entre 3 y 50 caracteres. \r\nNo debe contener caracteres esp" +
        "eciales ni estar vacio.\r\n");
            // 
            // pbNomCorrecto
            // 
            this.pbNomCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbNomCorrecto.ErrorImage")));
            this.pbNomCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNomCorrecto.Image")));
            this.pbNomCorrecto.Location = new System.Drawing.Point(351, 37);
            this.pbNomCorrecto.Name = "pbNomCorrecto";
            this.pbNomCorrecto.Size = new System.Drawing.Size(39, 38);
            this.pbNomCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNomCorrecto.TabIndex = 41;
            this.pbNomCorrecto.TabStop = false;
            // 
            // pbNomIncorrecto
            // 
            this.pbNomIncorrecto.ErrorImage = null;
            this.pbNomIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNomIncorrecto.Image")));
            this.pbNomIncorrecto.Location = new System.Drawing.Point(350, 38);
            this.pbNomIncorrecto.Name = "pbNomIncorrecto";
            this.pbNomIncorrecto.Size = new System.Drawing.Size(42, 35);
            this.pbNomIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNomIncorrecto.TabIndex = 40;
            this.pbNomIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNomIncorrecto, "El nombre debe tener entre 3 y 50 caracteres. \r\nNo debe contener caracteres espec" +
        "iales ni estar vacio.\r\n");
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.Teal;
            this.btnVolverAtras.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(555, 351);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(166, 49);
            this.btnVolverAtras.TabIndex = 16;
            this.btnVolverAtras.Text = "Volver Atrás";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(356, 351);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 49);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Navy;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(154, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 49);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Errores:";
            // 
            // FormAltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAltaProveedor";
            this.Text = "Alta de Nuevo Proveedor";
            this.Load += new System.EventHandler(this.FormAltaProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuitIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuitCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNomCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNomIncorrecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbNomCorrecto;
        private System.Windows.Forms.PictureBox pbNomIncorrecto;
        private System.Windows.Forms.PictureBox pbCuitIncorrecto;
        private System.Windows.Forms.PictureBox pbCuitCorrecto;
        private System.Windows.Forms.PictureBox pbEmailIncorrecto;
        private System.Windows.Forms.PictureBox pbEmailCorrecto;
        private System.Windows.Forms.PictureBox pbApellidoCorrecto;
        private System.Windows.Forms.PictureBox pbApellidoIncorrecto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}