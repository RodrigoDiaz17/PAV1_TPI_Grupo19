namespace BOTON
{
    partial class GRILLA
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.gdrPersonas = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel14.Location = new System.Drawing.Point(348, 160);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(547, 1);
            this.panel14.TabIndex = 1000000003;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Location = new System.Drawing.Point(894, 160);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 569);
            this.panel12.TabIndex = 1000000004;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel9.Location = new System.Drawing.Point(-544, 207);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(541, 1);
            this.panel9.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel11.Location = new System.Drawing.Point(348, 160);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 569);
            this.panel11.TabIndex = 1000000005;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel10.Location = new System.Drawing.Point(348, 728);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(547, 1);
            this.panel10.TabIndex = 1000000006;
            // 
            // gdrPersonas
            // 
            this.gdrPersonas.AllowUserToAddRows = false;
            this.gdrPersonas.AllowUserToDeleteRows = false;
            this.gdrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.gdrPersonas.Location = new System.Drawing.Point(351, 163);
            this.gdrPersonas.Name = "gdrPersonas";
            this.gdrPersonas.ReadOnly = true;
            this.gdrPersonas.RowHeadersWidth = 51;
            this.gdrPersonas.RowTemplate.Height = 24;
            this.gdrPersonas.Size = new System.Drawing.Size(541, 563);
            this.gdrPersonas.TabIndex = 1000000007;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo doc";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 40;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "NroDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 250;
            // 
            // GRILLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 837);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.gdrPersonas);
            this.Name = "GRILLA";
            this.Text = "GRILLA";
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView gdrPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}