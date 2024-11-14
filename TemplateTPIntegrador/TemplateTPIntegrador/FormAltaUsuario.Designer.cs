namespace TemplateTPIntegrador
{
    partial class FormAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Titulonacimientocliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbNombreCorrecto = new System.Windows.Forms.PictureBox();
            this.pbNombreIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbApellidoIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbApellidoCorrecto = new System.Windows.Forms.PictureBox();
            this.pbDireccionIncorrecta = new System.Windows.Forms.PictureBox();
            this.pbDireccionCorrecta = new System.Windows.Forms.PictureBox();
            this.pbTelefonoIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbTelefonoCorrecto = new System.Windows.Forms.PictureBox();
            this.pbDNIIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbDNICorrecto = new System.Windows.Forms.PictureBox();
            this.pbEmailIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbEmailCorrecto = new System.Windows.Forms.PictureBox();
            this.pbFechNacIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbFechNacCorrecto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblApeUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblNomUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMaxUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMinUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblInstruccionesRegistrar = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccionIncorrecta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccionCorrecta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonoIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonoCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNIIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNICorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechNacIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechNacCorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del nuevo usuario a crear:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(547, 95);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(249, 26);
            this.textBoxApellido.TabIndex = 4;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(25, 170);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(249, 26);
            this.textBoxDireccion.TabIndex = 6;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(549, 170);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(249, 26);
            this.textBoxTelefono.TabIndex = 8;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(25, 245);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(249, 26);
            this.textBoxDNI.TabIndex = 10;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(549, 258);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(249, 26);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 350);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 26);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Titulonacimientocliente
            // 
            this.Titulonacimientocliente.AutoSize = true;
            this.Titulonacimientocliente.Location = new System.Drawing.Point(21, 312);
            this.Titulonacimientocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulonacimientocliente.Name = "Titulonacimientocliente";
            this.Titulonacimientocliente.Size = new System.Drawing.Size(159, 20);
            this.Titulonacimientocliente.TabIndex = 15;
            this.Titulonacimientocliente.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Perfil:";
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Location = new System.Drawing.Point(549, 350);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(246, 28);
            this.comboBoxPerfil.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 21;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(36, 465);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(249, 26);
            this.textBoxUsuario.TabIndex = 20;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Usuario:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(755, 481);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(191, 40);
            this.buttonAceptar.TabIndex = 23;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(755, 558);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(191, 40);
            this.buttonVolver.TabIndex = 24;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(27, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(246, 26);
            this.textBoxNombre.TabIndex = 25;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 26;
            // 
            // pbNombreCorrecto
            // 
            this.pbNombreCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNombreCorrecto.Image")));
            this.pbNombreCorrecto.Location = new System.Drawing.Point(305, 74);
            this.pbNombreCorrecto.Name = "pbNombreCorrecto";
            this.pbNombreCorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbNombreCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombreCorrecto.TabIndex = 27;
            this.pbNombreCorrecto.TabStop = false;
            // 
            // pbNombreIncorrecto
            // 
            this.pbNombreIncorrecto.ErrorImage = null;
            this.pbNombreIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNombreIncorrecto.Image")));
            this.pbNombreIncorrecto.Location = new System.Drawing.Point(305, 74);
            this.pbNombreIncorrecto.Name = "pbNombreIncorrecto";
            this.pbNombreIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbNombreIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombreIncorrecto.TabIndex = 28;
            this.pbNombreIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNombreIncorrecto, "Errores:\r\nEl nombre debe tener entre 3 y 50 caracteres. \r\nNo debe contener caract" +
        "eres especiales\r\n");
            // 
            // pbApellidoIncorrecto
            // 
            this.pbApellidoIncorrecto.ErrorImage = null;
            this.pbApellidoIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbApellidoIncorrecto.Image")));
            this.pbApellidoIncorrecto.Location = new System.Drawing.Point(816, 74);
            this.pbApellidoIncorrecto.Name = "pbApellidoIncorrecto";
            this.pbApellidoIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbApellidoIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellidoIncorrecto.TabIndex = 30;
            this.pbApellidoIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbApellidoIncorrecto, "El apellido debe tener entre 3 y 50 caracteres. ");
            // 
            // pbApellidoCorrecto
            // 
            this.pbApellidoCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbApellidoCorrecto.ErrorImage")));
            this.pbApellidoCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbApellidoCorrecto.Image")));
            this.pbApellidoCorrecto.Location = new System.Drawing.Point(816, 74);
            this.pbApellidoCorrecto.Name = "pbApellidoCorrecto";
            this.pbApellidoCorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbApellidoCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellidoCorrecto.TabIndex = 29;
            this.pbApellidoCorrecto.TabStop = false;
            // 
            // pbDireccionIncorrecta
            // 
            this.pbDireccionIncorrecta.ErrorImage = null;
            this.pbDireccionIncorrecta.Image = ((System.Drawing.Image)(resources.GetObject("pbDireccionIncorrecta.Image")));
            this.pbDireccionIncorrecta.Location = new System.Drawing.Point(305, 149);
            this.pbDireccionIncorrecta.Name = "pbDireccionIncorrecta";
            this.pbDireccionIncorrecta.Size = new System.Drawing.Size(50, 47);
            this.pbDireccionIncorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDireccionIncorrecta.TabIndex = 32;
            this.pbDireccionIncorrecta.TabStop = false;
            // 
            // pbDireccionCorrecta
            // 
            this.pbDireccionCorrecta.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbDireccionCorrecta.ErrorImage")));
            this.pbDireccionCorrecta.Image = ((System.Drawing.Image)(resources.GetObject("pbDireccionCorrecta.Image")));
            this.pbDireccionCorrecta.Location = new System.Drawing.Point(305, 149);
            this.pbDireccionCorrecta.Name = "pbDireccionCorrecta";
            this.pbDireccionCorrecta.Size = new System.Drawing.Size(50, 47);
            this.pbDireccionCorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDireccionCorrecta.TabIndex = 31;
            this.pbDireccionCorrecta.TabStop = false;
            this.toolTip1.SetToolTip(this.pbDireccionCorrecta, "La direccion puede contener entre 3 y 255 caracteres.");
            // 
            // pbTelefonoIncorrecto
            // 
            this.pbTelefonoIncorrecto.ErrorImage = null;
            this.pbTelefonoIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbTelefonoIncorrecto.Image")));
            this.pbTelefonoIncorrecto.Location = new System.Drawing.Point(816, 149);
            this.pbTelefonoIncorrecto.Name = "pbTelefonoIncorrecto";
            this.pbTelefonoIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbTelefonoIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelefonoIncorrecto.TabIndex = 34;
            this.pbTelefonoIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbTelefonoIncorrecto, "El Teléfono debe tener entre 8 y 11 numeros\r\nNo debe tener caracteres especiales");
            // 
            // pbTelefonoCorrecto
            // 
            this.pbTelefonoCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbTelefonoCorrecto.ErrorImage")));
            this.pbTelefonoCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbTelefonoCorrecto.Image")));
            this.pbTelefonoCorrecto.Location = new System.Drawing.Point(816, 149);
            this.pbTelefonoCorrecto.Name = "pbTelefonoCorrecto";
            this.pbTelefonoCorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbTelefonoCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelefonoCorrecto.TabIndex = 33;
            this.pbTelefonoCorrecto.TabStop = false;
            // 
            // pbDNIIncorrecto
            // 
            this.pbDNIIncorrecto.ErrorImage = null;
            this.pbDNIIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbDNIIncorrecto.Image")));
            this.pbDNIIncorrecto.Location = new System.Drawing.Point(305, 225);
            this.pbDNIIncorrecto.Name = "pbDNIIncorrecto";
            this.pbDNIIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbDNIIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNIIncorrecto.TabIndex = 36;
            this.pbDNIIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbDNIIncorrecto, "El documento debe tener 7 u 8 caracteres. ");
            // 
            // pbDNICorrecto
            // 
            this.pbDNICorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbDNICorrecto.ErrorImage")));
            this.pbDNICorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbDNICorrecto.Image")));
            this.pbDNICorrecto.Location = new System.Drawing.Point(305, 225);
            this.pbDNICorrecto.Name = "pbDNICorrecto";
            this.pbDNICorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbDNICorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNICorrecto.TabIndex = 35;
            this.pbDNICorrecto.TabStop = false;
            // 
            // pbEmailIncorrecto
            // 
            this.pbEmailIncorrecto.ErrorImage = null;
            this.pbEmailIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailIncorrecto.Image")));
            this.pbEmailIncorrecto.Location = new System.Drawing.Point(816, 237);
            this.pbEmailIncorrecto.Name = "pbEmailIncorrecto";
            this.pbEmailIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbEmailIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmailIncorrecto.TabIndex = 38;
            this.pbEmailIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbEmailIncorrecto, "El mail debe contener un formato valido ( tener @ y terminar con .com)");
            // 
            // pbEmailCorrecto
            // 
            this.pbEmailCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbEmailCorrecto.ErrorImage")));
            this.pbEmailCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailCorrecto.Image")));
            this.pbEmailCorrecto.Location = new System.Drawing.Point(816, 237);
            this.pbEmailCorrecto.Name = "pbEmailCorrecto";
            this.pbEmailCorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbEmailCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmailCorrecto.TabIndex = 37;
            this.pbEmailCorrecto.TabStop = false;
            // 
            // pbFechNacIncorrecto
            // 
            this.pbFechNacIncorrecto.ErrorImage = null;
            this.pbFechNacIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbFechNacIncorrecto.Image")));
            this.pbFechNacIncorrecto.Location = new System.Drawing.Point(377, 331);
            this.pbFechNacIncorrecto.Name = "pbFechNacIncorrecto";
            this.pbFechNacIncorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbFechNacIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechNacIncorrecto.TabIndex = 42;
            this.pbFechNacIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbFechNacIncorrecto, "El usuario debe ser mayor de 18 años.");
            // 
            // pbFechNacCorrecto
            // 
            this.pbFechNacCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFechNacCorrecto.ErrorImage")));
            this.pbFechNacCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbFechNacCorrecto.Image")));
            this.pbFechNacCorrecto.Location = new System.Drawing.Point(377, 331);
            this.pbFechNacCorrecto.Name = "pbFechNacCorrecto";
            this.pbFechNacCorrecto.Size = new System.Drawing.Size(50, 47);
            this.pbFechNacCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechNacCorrecto.TabIndex = 41;
            this.pbFechNacCorrecto.TabStop = false;
            // 
            // lblApeUsuarioRegistrar
            // 
            this.lblApeUsuarioRegistrar.AutoSize = true;
            this.lblApeUsuarioRegistrar.Location = new System.Drawing.Point(327, 609);
            this.lblApeUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApeUsuarioRegistrar.Name = "lblApeUsuarioRegistrar";
            this.lblApeUsuarioRegistrar.Size = new System.Drawing.Size(300, 24);
            this.lblApeUsuarioRegistrar.TabIndex = 70;
            this.lblApeUsuarioRegistrar.Text = "No debe contener el apellido del usuario";
            this.lblApeUsuarioRegistrar.UseCompatibleTextRendering = true;
            // 
            // lblNomUsuarioRegistrar
            // 
            this.lblNomUsuarioRegistrar.AutoSize = true;
            this.lblNomUsuarioRegistrar.Location = new System.Drawing.Point(327, 570);
            this.lblNomUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsuarioRegistrar.Name = "lblNomUsuarioRegistrar";
            this.lblNomUsuarioRegistrar.Size = new System.Drawing.Size(291, 20);
            this.lblNomUsuarioRegistrar.TabIndex = 69;
            this.lblNomUsuarioRegistrar.Text = "No debe contener el nombre del usuario";
            // 
            // lblMaxUsuarioRegistrar
            // 
            this.lblMaxUsuarioRegistrar.AutoSize = true;
            this.lblMaxUsuarioRegistrar.Location = new System.Drawing.Point(327, 532);
            this.lblMaxUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxUsuarioRegistrar.Name = "lblMaxUsuarioRegistrar";
            this.lblMaxUsuarioRegistrar.Size = new System.Drawing.Size(290, 20);
            this.lblMaxUsuarioRegistrar.TabIndex = 68;
            this.lblMaxUsuarioRegistrar.Text = "Debe contener menos de 15 caracteres";
            // 
            // lblMinUsuarioRegistrar
            // 
            this.lblMinUsuarioRegistrar.AutoSize = true;
            this.lblMinUsuarioRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinUsuarioRegistrar.Location = new System.Drawing.Point(327, 493);
            this.lblMinUsuarioRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinUsuarioRegistrar.Name = "lblMinUsuarioRegistrar";
            this.lblMinUsuarioRegistrar.Size = new System.Drawing.Size(263, 20);
            this.lblMinUsuarioRegistrar.TabIndex = 67;
            this.lblMinUsuarioRegistrar.Text = "Debe contener más de 8 caracteres";
            // 
            // lblInstruccionesRegistrar
            // 
            this.lblInstruccionesRegistrar.AutoSize = true;
            this.lblInstruccionesRegistrar.Location = new System.Drawing.Point(327, 455);
            this.lblInstruccionesRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruccionesRegistrar.Name = "lblInstruccionesRegistrar";
            this.lblInstruccionesRegistrar.Size = new System.Drawing.Size(316, 20);
            this.lblInstruccionesRegistrar.TabIndex = 66;
            this.lblInstruccionesRegistrar.Text = "Tenga en cuenta que el nombre de usuario:";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(36, 565);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(249, 26);
            this.textBoxContraseña.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 532);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Contraseña:";
            // 
            // FormAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblApeUsuarioRegistrar);
            this.Controls.Add(this.lblNomUsuarioRegistrar);
            this.Controls.Add(this.lblMaxUsuarioRegistrar);
            this.Controls.Add(this.lblMinUsuarioRegistrar);
            this.Controls.Add(this.lblInstruccionesRegistrar);
            this.Controls.Add(this.pbFechNacIncorrecto);
            this.Controls.Add(this.pbFechNacCorrecto);
            this.Controls.Add(this.pbEmailIncorrecto);
            this.Controls.Add(this.pbEmailCorrecto);
            this.Controls.Add(this.pbDNIIncorrecto);
            this.Controls.Add(this.pbDNICorrecto);
            this.Controls.Add(this.pbTelefonoIncorrecto);
            this.Controls.Add(this.pbTelefonoCorrecto);
            this.Controls.Add(this.pbDireccionIncorrecta);
            this.Controls.Add(this.pbDireccionCorrecta);
            this.Controls.Add(this.pbApellidoIncorrecto);
            this.Controls.Add(this.pbApellidoCorrecto);
            this.Controls.Add(this.pbNombreIncorrecto);
            this.Controls.Add(this.pbNombreCorrecto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxPerfil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Titulonacimientocliente);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaUsuario";
            this.Text = "Alta Usuario";
            this.Load += new System.EventHandler(this.FormAltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccionIncorrecta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDireccionCorrecta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonoIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefonoCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNIIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNICorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechNacIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechNacCorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Titulonacimientocliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbNombreCorrecto;
        private System.Windows.Forms.PictureBox pbNombreIncorrecto;
        private System.Windows.Forms.PictureBox pbApellidoIncorrecto;
        private System.Windows.Forms.PictureBox pbApellidoCorrecto;
        private System.Windows.Forms.PictureBox pbDireccionIncorrecta;
        private System.Windows.Forms.PictureBox pbDireccionCorrecta;
        private System.Windows.Forms.PictureBox pbTelefonoIncorrecto;
        private System.Windows.Forms.PictureBox pbTelefonoCorrecto;
        private System.Windows.Forms.PictureBox pbDNIIncorrecto;
        private System.Windows.Forms.PictureBox pbDNICorrecto;
        private System.Windows.Forms.PictureBox pbEmailIncorrecto;
        private System.Windows.Forms.PictureBox pbEmailCorrecto;
        private System.Windows.Forms.PictureBox pbFechNacIncorrecto;
        private System.Windows.Forms.PictureBox pbFechNacCorrecto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblApeUsuarioRegistrar;
        private System.Windows.Forms.Label lblNomUsuarioRegistrar;
        private System.Windows.Forms.Label lblMaxUsuarioRegistrar;
        private System.Windows.Forms.Label lblMinUsuarioRegistrar;
        private System.Windows.Forms.Label lblInstruccionesRegistrar;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label12;
    }
}