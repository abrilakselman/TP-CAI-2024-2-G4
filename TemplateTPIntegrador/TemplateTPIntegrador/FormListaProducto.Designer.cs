﻿namespace TemplateTPIntegrador
{
    partial class FormListaProducto
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
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAltaProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBajaProd = new System.Windows.Forms.Button();
            this.buttonModificarProd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBajaProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(21, 77);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersWidth = 62;
            this.dgvListaProductos.RowTemplate.Height = 28;
            this.dgvListaProductos.Size = new System.Drawing.Size(832, 449);
            this.dgvListaProductos.TabIndex = 0;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Productos";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(880, 77);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(186, 28);
            this.comboBoxCat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(916, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAltaProd
            // 
            this.buttonAltaProd.BackColor = System.Drawing.Color.Navy;
            this.buttonAltaProd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltaProd.ForeColor = System.Drawing.Color.White;
            this.buttonAltaProd.Location = new System.Drawing.Point(900, 242);
            this.buttonAltaProd.Name = "buttonAltaProd";
            this.buttonAltaProd.Size = new System.Drawing.Size(141, 52);
            this.buttonAltaProd.TabIndex = 5;
            this.buttonAltaProd.Text = "Alta";
            this.buttonAltaProd.UseVisualStyleBackColor = false;
            this.buttonAltaProd.Click += new System.EventHandler(this.buttonAltaProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // buttonBajaProd
            // 
            this.buttonBajaProd.BackColor = System.Drawing.Color.Maroon;
            this.buttonBajaProd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajaProd.ForeColor = System.Drawing.Color.White;
            this.buttonBajaProd.Location = new System.Drawing.Point(900, 475);
            this.buttonBajaProd.Name = "buttonBajaProd";
            this.buttonBajaProd.Size = new System.Drawing.Size(141, 52);
            this.buttonBajaProd.TabIndex = 7;
            this.buttonBajaProd.Text = "Baja";
            this.buttonBajaProd.UseVisualStyleBackColor = false;
            this.buttonBajaProd.Click += new System.EventHandler(this.buttonBajaProd_Click);
            // 
            // buttonModificarProd
            // 
            this.buttonModificarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonModificarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProd.ForeColor = System.Drawing.Color.White;
            this.buttonModificarProd.Location = new System.Drawing.Point(900, 300);
            this.buttonModificarProd.Name = "buttonModificarProd";
            this.buttonModificarProd.Size = new System.Drawing.Size(141, 52);
            this.buttonModificarProd.TabIndex = 8;
            this.buttonModificarProd.Text = "Modificar";
            this.buttonModificarProd.UseVisualStyleBackColor = false;
            this.buttonModificarProd.Click += new System.EventHandler(this.buttonModificarProd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Producto a Eliminar:";
            // 
            // textBoxBajaProd
            // 
            this.textBoxBajaProd.Location = new System.Drawing.Point(864, 425);
            this.textBoxBajaProd.Name = "textBoxBajaProd";
            this.textBoxBajaProd.Size = new System.Drawing.Size(230, 26);
            this.textBoxBajaProd.TabIndex = 9;
            this.textBoxBajaProd.TextChanged += new System.EventHandler(this.textBoxBajaProd_TextChanged);
            // 
            // FormListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBajaProd);
            this.Controls.Add(this.buttonModificarProd);
            this.Controls.Add(this.buttonBajaProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAltaProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProductos);
            this.Name = "FormListaProducto";
            this.Text = "Lista de Producto";
            this.Load += new System.EventHandler(this.FormListaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAltaProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBajaProd;
        private System.Windows.Forms.Button buttonModificarProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBajaProd;
    }
}