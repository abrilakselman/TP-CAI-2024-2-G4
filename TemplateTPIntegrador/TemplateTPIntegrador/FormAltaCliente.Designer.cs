namespace TemplateTPIntegrador
{
    partial class FormAltaCliente
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
            this.textBoxClienteNombre = new System.Windows.Forms.TextBox();
            this.TituloAltaCliente = new System.Windows.Forms.Label();
            this.NombreCliente = new System.Windows.Forms.Label();
            this.TituloApellidoCliente = new System.Windows.Forms.Label();
            this.TituloDireccionCliente = new System.Windows.Forms.Label();
            this.TituloTelefonoCliente = new System.Windows.Forms.Label();
            this.TituloEmailCliente = new System.Windows.Forms.Label();
            this.Titulonacimientocliente = new System.Windows.Forms.Label();
            this.TituloDNICliente = new System.Windows.Forms.Label();
            this.textBoxClienteApellido = new System.Windows.Forms.TextBox();
            this.textBoxClienteDNI = new System.Windows.Forms.TextBox();
            this.textBoxClienteTelefono = new System.Windows.Forms.TextBox();
            this.textBoxClienteDireccion = new System.Windows.Forms.TextBox();
            this.textBoxClienteMail = new System.Windows.Forms.TextBox();
            this.dateTimePickerCL = new System.Windows.Forms.DateTimePicker();
            this.buttonAceptarCliente = new System.Windows.Forms.Button();
            this.buttonVolverAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxClienteNombre
            // 
            this.textBoxClienteNombre.Location = new System.Drawing.Point(18, 169);
            this.textBoxClienteNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteNombre.Name = "textBoxClienteNombre";
            this.textBoxClienteNombre.Size = new System.Drawing.Size(344, 26);
            this.textBoxClienteNombre.TabIndex = 0;
            // 
            // TituloAltaCliente
            // 
            this.TituloAltaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TituloAltaCliente.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloAltaCliente.ForeColor = System.Drawing.Color.White;
            this.TituloAltaCliente.Location = new System.Drawing.Point(9, 31);
            this.TituloAltaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloAltaCliente.Name = "TituloAltaCliente";
            this.TituloAltaCliente.Size = new System.Drawing.Size(1023, 62);
            this.TituloAltaCliente.TabIndex = 1;
            this.TituloAltaCliente.Text = "Alta de Cliente";
            this.TituloAltaCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Location = new System.Drawing.Point(18, 145);
            this.NombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(65, 20);
            this.NombreCliente.TabIndex = 2;
            this.NombreCliente.Text = "Nombre";
            this.NombreCliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TituloApellidoCliente
            // 
            this.TituloApellidoCliente.AutoSize = true;
            this.TituloApellidoCliente.Location = new System.Drawing.Point(524, 145);
            this.TituloApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloApellidoCliente.Name = "TituloApellidoCliente";
            this.TituloApellidoCliente.Size = new System.Drawing.Size(65, 20);
            this.TituloApellidoCliente.TabIndex = 3;
            this.TituloApellidoCliente.Text = "Apellido";
            this.TituloApellidoCliente.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TituloDireccionCliente
            // 
            this.TituloDireccionCliente.AutoSize = true;
            this.TituloDireccionCliente.Location = new System.Drawing.Point(18, 426);
            this.TituloDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloDireccionCliente.Name = "TituloDireccionCliente";
            this.TituloDireccionCliente.Size = new System.Drawing.Size(75, 20);
            this.TituloDireccionCliente.TabIndex = 4;
            this.TituloDireccionCliente.Text = "Dirección";
            // 
            // TituloTelefonoCliente
            // 
            this.TituloTelefonoCliente.AutoSize = true;
            this.TituloTelefonoCliente.Location = new System.Drawing.Point(18, 231);
            this.TituloTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloTelefonoCliente.Name = "TituloTelefonoCliente";
            this.TituloTelefonoCliente.Size = new System.Drawing.Size(71, 20);
            this.TituloTelefonoCliente.TabIndex = 5;
            this.TituloTelefonoCliente.Text = "Teléfono";
            // 
            // TituloEmailCliente
            // 
            this.TituloEmailCliente.AutoSize = true;
            this.TituloEmailCliente.Location = new System.Drawing.Point(524, 231);
            this.TituloEmailCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloEmailCliente.Name = "TituloEmailCliente";
            this.TituloEmailCliente.Size = new System.Drawing.Size(48, 20);
            this.TituloEmailCliente.TabIndex = 6;
            this.TituloEmailCliente.Text = "Email";
            // 
            // Titulonacimientocliente
            // 
            this.Titulonacimientocliente.AutoSize = true;
            this.Titulonacimientocliente.Location = new System.Drawing.Point(524, 326);
            this.Titulonacimientocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulonacimientocliente.Name = "Titulonacimientocliente";
            this.Titulonacimientocliente.Size = new System.Drawing.Size(159, 20);
            this.Titulonacimientocliente.TabIndex = 7;
            this.Titulonacimientocliente.Text = "Fecha de Nacimiento";
            // 
            // TituloDNICliente
            // 
            this.TituloDNICliente.AutoSize = true;
            this.TituloDNICliente.Location = new System.Drawing.Point(18, 326);
            this.TituloDNICliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloDNICliente.Name = "TituloDNICliente";
            this.TituloDNICliente.Size = new System.Drawing.Size(37, 20);
            this.TituloDNICliente.TabIndex = 8;
            this.TituloDNICliente.Text = "DNI";
            // 
            // textBoxClienteApellido
            // 
            this.textBoxClienteApellido.Location = new System.Drawing.Point(528, 169);
            this.textBoxClienteApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteApellido.Name = "textBoxClienteApellido";
            this.textBoxClienteApellido.Size = new System.Drawing.Size(330, 26);
            this.textBoxClienteApellido.TabIndex = 9;
            // 
            // textBoxClienteDNI
            // 
            this.textBoxClienteDNI.Location = new System.Drawing.Point(18, 351);
            this.textBoxClienteDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteDNI.Name = "textBoxClienteDNI";
            this.textBoxClienteDNI.Size = new System.Drawing.Size(344, 26);
            this.textBoxClienteDNI.TabIndex = 10;
            // 
            // textBoxClienteTelefono
            // 
            this.textBoxClienteTelefono.Location = new System.Drawing.Point(18, 255);
            this.textBoxClienteTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteTelefono.Name = "textBoxClienteTelefono";
            this.textBoxClienteTelefono.Size = new System.Drawing.Size(344, 26);
            this.textBoxClienteTelefono.TabIndex = 11;
            // 
            // textBoxClienteDireccion
            // 
            this.textBoxClienteDireccion.Location = new System.Drawing.Point(18, 451);
            this.textBoxClienteDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteDireccion.Name = "textBoxClienteDireccion";
            this.textBoxClienteDireccion.Size = new System.Drawing.Size(344, 26);
            this.textBoxClienteDireccion.TabIndex = 12;
            // 
            // textBoxClienteMail
            // 
            this.textBoxClienteMail.Location = new System.Drawing.Point(528, 255);
            this.textBoxClienteMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClienteMail.Name = "textBoxClienteMail";
            this.textBoxClienteMail.Size = new System.Drawing.Size(330, 26);
            this.textBoxClienteMail.TabIndex = 13;
            // 
            // dateTimePickerCL
            // 
            this.dateTimePickerCL.Location = new System.Drawing.Point(528, 351);
            this.dateTimePickerCL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerCL.Name = "dateTimePickerCL";
            this.dateTimePickerCL.Size = new System.Drawing.Size(330, 26);
            this.dateTimePickerCL.TabIndex = 14;
            // 
            // buttonAceptarCliente
            // 
            this.buttonAceptarCliente.BackColor = System.Drawing.Color.Navy;
            this.buttonAceptarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAceptarCliente.Location = new System.Drawing.Point(704, 471);
            this.buttonAceptarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptarCliente.Name = "buttonAceptarCliente";
            this.buttonAceptarCliente.Size = new System.Drawing.Size(156, 49);
            this.buttonAceptarCliente.TabIndex = 15;
            this.buttonAceptarCliente.Text = "Aceptar";
            this.buttonAceptarCliente.UseVisualStyleBackColor = false;
            this.buttonAceptarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVolverAC
            // 
            this.buttonVolverAC.BackColor = System.Drawing.Color.Teal;
            this.buttonVolverAC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVolverAC.Location = new System.Drawing.Point(890, 471);
            this.buttonVolverAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVolverAC.Name = "buttonVolverAC";
            this.buttonVolverAC.Size = new System.Drawing.Size(142, 49);
            this.buttonVolverAC.TabIndex = 16;
            this.buttonVolverAC.Text = "Volver";
            this.buttonVolverAC.UseVisualStyleBackColor = false;
            this.buttonVolverAC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 538);
            this.Controls.Add(this.buttonVolverAC);
            this.Controls.Add(this.buttonAceptarCliente);
            this.Controls.Add(this.dateTimePickerCL);
            this.Controls.Add(this.textBoxClienteMail);
            this.Controls.Add(this.textBoxClienteDireccion);
            this.Controls.Add(this.textBoxClienteTelefono);
            this.Controls.Add(this.textBoxClienteDNI);
            this.Controls.Add(this.textBoxClienteApellido);
            this.Controls.Add(this.TituloDNICliente);
            this.Controls.Add(this.Titulonacimientocliente);
            this.Controls.Add(this.TituloEmailCliente);
            this.Controls.Add(this.TituloTelefonoCliente);
            this.Controls.Add(this.TituloDireccionCliente);
            this.Controls.Add(this.TituloApellidoCliente);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.TituloAltaCliente);
            this.Controls.Add(this.textBoxClienteNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAltaCliente";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.FormAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClienteNombre;
        private System.Windows.Forms.Label TituloAltaCliente;
        private System.Windows.Forms.Label NombreCliente;
        private System.Windows.Forms.Label TituloApellidoCliente;
        private System.Windows.Forms.Label TituloDireccionCliente;
        private System.Windows.Forms.Label TituloTelefonoCliente;
        private System.Windows.Forms.Label TituloEmailCliente;
        private System.Windows.Forms.Label Titulonacimientocliente;
        private System.Windows.Forms.Label TituloDNICliente;
        private System.Windows.Forms.TextBox textBoxClienteApellido;
        private System.Windows.Forms.TextBox textBoxClienteDNI;
        private System.Windows.Forms.TextBox textBoxClienteTelefono;
        private System.Windows.Forms.TextBox textBoxClienteDireccion;
        private System.Windows.Forms.TextBox textBoxClienteMail;
        private System.Windows.Forms.DateTimePicker dateTimePickerCL;
        private System.Windows.Forms.Button buttonAceptarCliente;
        private System.Windows.Forms.Button buttonVolverAC;
    }
}