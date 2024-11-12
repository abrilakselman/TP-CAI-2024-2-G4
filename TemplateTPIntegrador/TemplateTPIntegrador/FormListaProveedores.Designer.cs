using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    partial class FormListaProveedores
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
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModProv = new System.Windows.Forms.Button();
            this.btnBajaProv = new System.Windows.Forms.Button();
            this.btnAltaProv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBajaProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.AllowUserToOrderColumns = true;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Location = new System.Drawing.Point(12, 92);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersWidth = 62;
            this.dgvListaProveedores.RowTemplate.Height = 28;
            this.dgvListaProveedores.Size = new System.Drawing.Size(854, 443);
            this.dgvListaProveedores.TabIndex = 0;
            this.dgvListaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Proveedores";
            // 
            // btnModProv
            // 
            this.btnModProv.Location = new System.Drawing.Point(894, 171);
            this.btnModProv.Name = "btnModProv";
            this.btnModProv.Size = new System.Drawing.Size(156, 54);
            this.btnModProv.TabIndex = 7;
            this.btnModProv.Text = "Modificar";
            this.btnModProv.UseVisualStyleBackColor = true;
            // 
            // btnBajaProv
            // 
            this.btnBajaProv.Location = new System.Drawing.Point(894, 384);
            this.btnBajaProv.Name = "btnBajaProv";
            this.btnBajaProv.Size = new System.Drawing.Size(156, 54);
            this.btnBajaProv.TabIndex = 6;
            this.btnBajaProv.Text = "Baja";
            this.btnBajaProv.UseVisualStyleBackColor = true;
            this.btnBajaProv.Click += new System.EventHandler(this.btnBajaProv_Click);
            // 
            // btnAltaProv
            // 
            this.btnAltaProv.Location = new System.Drawing.Point(894, 92);
            this.btnAltaProv.Name = "btnAltaProv";
            this.btnAltaProv.Size = new System.Drawing.Size(156, 54);
            this.btnAltaProv.TabIndex = 5;
            this.btnAltaProv.Text = "Alta";
            this.btnAltaProv.UseVisualStyleBackColor = true;
            this.btnAltaProv.Click += new System.EventHandler(this.btnAltaProv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(872, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proveedor a Eliminar:";
            // 
            // textBoxBajaProv
            // 
            this.textBoxBajaProv.Location = new System.Drawing.Point(878, 338);
            this.textBoxBajaProv.Name = "textBoxBajaProv";
            this.textBoxBajaProv.Size = new System.Drawing.Size(231, 26);
            this.textBoxBajaProv.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Haga click en el ID de la persona a dar de baja";
            // 
            // FormListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBajaProv);
            this.Controls.Add(this.btnModProv);
            this.Controls.Add(this.btnBajaProv);
            this.Controls.Add(this.btnAltaProv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProveedores);
            this.Name = "FormListaProveedores";
            this.Text = "FormListaProveedores";
            this.Load += new System.EventHandler(this.FormListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private DataGridView dgvListaProveedores;
        private Label label1;
        private Button btnModProv;
        private Button btnBajaProv;
        private Button btnAltaProv;
        private Label label2;
        private TextBox textBoxBajaProv;
        private Label label3;
    }
}