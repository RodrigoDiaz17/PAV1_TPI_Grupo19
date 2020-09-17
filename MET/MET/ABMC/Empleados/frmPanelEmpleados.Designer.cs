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
            this.PanelMenuStrip = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnBorrarEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmpleados.SuspendLayout();
            this.PanelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContenedor.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 29);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 421);
            this.PanelContenedor.TabIndex = 0;
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEmpleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarEmpleado,
            this.btnRegistrarEmpleados,
            this.btnBorrarEmpleados,
            this.btnSalir});
            this.menuEmpleados.Location = new System.Drawing.Point(0, 0);
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(800, 30);
            this.menuEmpleados.TabIndex = 0;
            this.menuEmpleados.Text = "menuStrip1";
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(163, 24);
            this.btnConsultarEmpleado.Text = "Consultar Empleados";
            // 
            // btnRegistrarEmpleados
            // 
            this.btnRegistrarEmpleados.Name = "btnRegistrarEmpleados";
            this.btnRegistrarEmpleados.Size = new System.Drawing.Size(160, 24);
            this.btnRegistrarEmpleados.Text = "Regsitrar Empleados";
            // 
            // PanelMenuStrip
            // 
            this.PanelMenuStrip.Controls.Add(this.menuEmpleados);
            this.PanelMenuStrip.Controls.Add(this.panelBarra);
            this.PanelMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuStrip.Name = "PanelMenuStrip";
            this.PanelMenuStrip.Size = new System.Drawing.Size(800, 29);
            this.PanelMenuStrip.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarra.Location = new System.Drawing.Point(0, 28);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(800, 1);
            this.panelBarra.TabIndex = 1;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(142, 24);
            this.btnBorrarEmpleados.Text = "Borrar Empleados";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPanelEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuEmpleados;
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
        private System.Windows.Forms.ToolStripMenuItem btnBorrarEmpleados;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}