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
            this.dgvListaProveedores.Location = new System.Drawing.Point(8, 60);
            this.dgvListaProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersWidth = 62;
            this.dgvListaProveedores.RowTemplate.Height = 28;
            this.dgvListaProveedores.Size = new System.Drawing.Size(569, 288);
            this.dgvListaProveedores.TabIndex = 0;
            this.dgvListaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Proveedores";
            // 
            // btnModProv
            // 
            this.btnModProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModProv.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModProv.ForeColor = System.Drawing.Color.White;
            this.btnModProv.Location = new System.Drawing.Point(596, 111);
            this.btnModProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnModProv.Name = "btnModProv";
            this.btnModProv.Size = new System.Drawing.Size(104, 35);
            this.btnModProv.TabIndex = 7;
            this.btnModProv.Text = "Modificar";
            this.btnModProv.UseVisualStyleBackColor = false;
            // 
            // btnBajaProv
            // 
            this.btnBajaProv.BackColor = System.Drawing.Color.Maroon;
            this.btnBajaProv.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaProv.ForeColor = System.Drawing.Color.White;
            this.btnBajaProv.Location = new System.Drawing.Point(596, 250);
            this.btnBajaProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajaProv.Name = "btnBajaProv";
            this.btnBajaProv.Size = new System.Drawing.Size(104, 35);
            this.btnBajaProv.TabIndex = 6;
            this.btnBajaProv.Text = "Baja";
            this.btnBajaProv.UseVisualStyleBackColor = false;
            this.btnBajaProv.Click += new System.EventHandler(this.btnBajaProv_Click);
            // 
            // btnAltaProv
            // 
            this.btnAltaProv.BackColor = System.Drawing.Color.Navy;
            this.btnAltaProv.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProv.ForeColor = System.Drawing.Color.White;
            this.btnAltaProv.Location = new System.Drawing.Point(596, 60);
            this.btnAltaProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaProv.Name = "btnAltaProv";
            this.btnAltaProv.Size = new System.Drawing.Size(104, 35);
            this.btnAltaProv.TabIndex = 5;
            this.btnAltaProv.Text = "Alta";
            this.btnAltaProv.UseVisualStyleBackColor = false;
            this.btnAltaProv.Click += new System.EventHandler(this.btnAltaProv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proveedor a Eliminar:";
            // 
            // textBoxBajaProv
            // 
            this.textBoxBajaProv.Location = new System.Drawing.Point(585, 220);
            this.textBoxBajaProv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBajaProv.Name = "textBoxBajaProv";
            this.textBoxBajaProv.Size = new System.Drawing.Size(155, 20);
            this.textBoxBajaProv.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Haga click en el ID de la persona a dar de baja";
            // 
            // FormListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBajaProv);
            this.Controls.Add(this.btnModProv);
            this.Controls.Add(this.btnBajaProv);
            this.Controls.Add(this.btnAltaProv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProveedores);
            this.Margin = new System.Windows.Forms.Padding(2);
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