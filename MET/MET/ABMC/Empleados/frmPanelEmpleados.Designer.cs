namespace MET.ABMC.Empleados
{
    partial class frmPanelEmpleados
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
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuEmpleados = new System.Windows.Forms.MenuStrip();
            this.btnConsultarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenuStrip = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.menuEmpleados.SuspendLayout();
            this.PanelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContenedor.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 24);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(686, 342);
            this.PanelContenedor.TabIndex = 0;
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEmpleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarEmpleado,
            this.btnRegistrarEmpleados,
            this.btnSalir});
            this.menuEmpleados.Location = new System.Drawing.Point(0, 0);
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEmpleados.Size = new System.Drawing.Size(686, 24);
            this.menuEmpleados.TabIndex = 0;
            this.menuEmpleados.Text = "menuStrip1";
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(131, 20);
            this.btnConsultarEmpleado.Text = "Consultar Empleados";
            this.btnConsultarEmpleado.Click += new System.EventHandler(this.btnConsultarEmpleado_Click);
            // 
            // btnRegistrarEmpleados
            // 
            this.btnRegistrarEmpleados.Name = "btnRegistrarEmpleados";
            this.btnRegistrarEmpleados.Size = new System.Drawing.Size(126, 20);
            this.btnRegistrarEmpleados.Text = "Regsitrar Empleados";
            this.btnRegistrarEmpleados.Click += new System.EventHandler(this.btnRegistrarEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 20);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelMenuStrip
            // 
            this.PanelMenuStrip.Controls.Add(this.menuEmpleados);
            this.PanelMenuStrip.Controls.Add(this.panelBarra);
            this.PanelMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenuStrip.Name = "PanelMenuStrip";
            this.PanelMenuStrip.Size = new System.Drawing.Size(686, 24);
            this.PanelMenuStrip.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarra.Location = new System.Drawing.Point(0, 23);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(686, 1);
            this.panelBarra.TabIndex = 1;
            // 
            // frmPanelEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuEmpleados;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPanelEmpleados";
            this.Text = "frmPanelEmpleados";
            this.menuEmpleados.ResumeLayout(false);
            this.menuEmpleados.PerformLayout();
            this.PanelMenuStrip.ResumeLayout(false);
            this.PanelMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.MenuStrip menuEmpleados;
        private System.Windows.Forms.Panel PanelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnRegistrarEmpleados;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}