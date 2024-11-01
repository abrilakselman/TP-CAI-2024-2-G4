namespace TemplateTPIntegrador
{
    partial class FormAltaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaProducto));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbStockCorrecto = new System.Windows.Forms.PictureBox();
            this.pbStockIncorrecto = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbPrecioCorrecto = new System.Windows.Forms.PictureBox();
            this.pbPrecioIncorrecto = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbNombCorrecto = new System.Windows.Forms.PictureBox();
            this.pbNombIncorrecto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombCorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombIncorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 50);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(154, 26);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(104, 115);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(154, 26);
            this.textBoxPrecio.TabIndex = 2;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(104, 181);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(154, 26);
            this.textBoxStock.TabIndex = 4;
            this.textBoxStock.TextChanged += new System.EventHandler(this.textBoxStock_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(543, 67);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(153, 28);
            this.cmbCategoria.TabIndex = 8;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(543, 128);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(153, 28);
            this.cmbProveedor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proveedor:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(103, 332);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 50);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(304, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 50);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Location = new System.Drawing.Point(504, 332);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(166, 50);
            this.btnVolverAtras.TabIndex = 13;
            this.btnVolverAtras.Text = "Volver Atrás";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbStockCorrecto);
            this.groupBox1.Controls.Add(this.pbStockIncorrecto);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pbPrecioCorrecto);
            this.groupBox1.Controls.Add(this.pbPrecioIncorrecto);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pbNombCorrecto);
            this.groupBox1.Controls.Add(this.pbNombIncorrecto);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(32, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 258);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Nuevo Producto:";
            // 
            // pbStockCorrecto
            // 
            this.pbStockCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbStockCorrecto.ErrorImage")));
            this.pbStockCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbStockCorrecto.Image")));
            this.pbStockCorrecto.Location = new System.Drawing.Point(292, 167);
            this.pbStockCorrecto.Name = "pbStockCorrecto";
            this.pbStockCorrecto.Size = new System.Drawing.Size(39, 38);
            this.pbStockCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStockCorrecto.TabIndex = 38;
            this.pbStockCorrecto.TabStop = false;
            // 
            // pbStockIncorrecto
            // 
            this.pbStockIncorrecto.ErrorImage = null;
            this.pbStockIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbStockIncorrecto.Image")));
            this.pbStockIncorrecto.Location = new System.Drawing.Point(292, 167);
            this.pbStockIncorrecto.Name = "pbStockIncorrecto";
            this.pbStockIncorrecto.Size = new System.Drawing.Size(42, 36);
            this.pbStockIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStockIncorrecto.TabIndex = 37;
            this.pbStockIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbStockIncorrecto, "Errores:\r\nEl stock no puede ser negativo. \r\nNo debe contener caracteres especiale" +
        "s ni espacios vacios.\r\n");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(292, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pbPrecioCorrecto
            // 
            this.pbPrecioCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbPrecioCorrecto.ErrorImage")));
            this.pbPrecioCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbPrecioCorrecto.Image")));
            this.pbPrecioCorrecto.Location = new System.Drawing.Point(292, 101);
            this.pbPrecioCorrecto.Name = "pbPrecioCorrecto";
            this.pbPrecioCorrecto.Size = new System.Drawing.Size(39, 38);
            this.pbPrecioCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrecioCorrecto.TabIndex = 35;
            this.pbPrecioCorrecto.TabStop = false;
            // 
            // pbPrecioIncorrecto
            // 
            this.pbPrecioIncorrecto.ErrorImage = null;
            this.pbPrecioIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbPrecioIncorrecto.Image")));
            this.pbPrecioIncorrecto.Location = new System.Drawing.Point(292, 101);
            this.pbPrecioIncorrecto.Name = "pbPrecioIncorrecto";
            this.pbPrecioIncorrecto.Size = new System.Drawing.Size(42, 36);
            this.pbPrecioIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrecioIncorrecto.TabIndex = 34;
            this.pbPrecioIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPrecioIncorrecto, "Errores:\r\nEl precio no puede ser negativo. \r\nNo debe contener caracteres especial" +
        "es ni espacios vacios.\r\n");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(292, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pbNombCorrecto
            // 
            this.pbNombCorrecto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbNombCorrecto.ErrorImage")));
            this.pbNombCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNombCorrecto.Image")));
            this.pbNombCorrecto.Location = new System.Drawing.Point(296, 36);
            this.pbNombCorrecto.Name = "pbNombCorrecto";
            this.pbNombCorrecto.Size = new System.Drawing.Size(39, 38);
            this.pbNombCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombCorrecto.TabIndex = 32;
            this.pbNombCorrecto.TabStop = false;
            // 
            // pbNombIncorrecto
            // 
            this.pbNombIncorrecto.ErrorImage = null;
            this.pbNombIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbNombIncorrecto.Image")));
            this.pbNombIncorrecto.Location = new System.Drawing.Point(294, 38);
            this.pbNombIncorrecto.Name = "pbNombIncorrecto";
            this.pbNombIncorrecto.Size = new System.Drawing.Size(42, 36);
            this.pbNombIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombIncorrecto.TabIndex = 30;
            this.pbNombIncorrecto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNombIncorrecto, "Errores:\r\nEl nombre debe tener entre 3 y 50 caracteres. \r\nNo debe contener caract" +
        "eres especiales ni estar vacio.\r\n");
            // 
            // FormAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FormAltaProducto";
            this.Text = "Alta Nuevo Producto";
            this.Load += new System.EventHandler(this.FormAltaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombCorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombIncorrecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbNombIncorrecto;
        private System.Windows.Forms.PictureBox pbNombCorrecto;
        private System.Windows.Forms.PictureBox pbStockCorrecto;
        private System.Windows.Forms.PictureBox pbStockIncorrecto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbPrecioCorrecto;
        private System.Windows.Forms.PictureBox pbPrecioIncorrecto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}