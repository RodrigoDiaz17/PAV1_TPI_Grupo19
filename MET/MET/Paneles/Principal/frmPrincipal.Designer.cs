namespace MET.Paneles
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal = new System.Windows.Forms.Panel();
            this.menuTemas = new System.Windows.Forms.MenuStrip();
            this.btnTema = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOscuro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlateado = new System.Windows.Forms.ToolStripMenuItem();
            this.temaForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMenuSlide = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.menuTemas.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.Ivory;
            this.lblTime.Name = "lblTime";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.ForeColor = System.Drawing.Color.Ivory;
            this.lblFecha.Name = "lblFecha";
            // 
            // timerTiempo
            // 
            this.timerTiempo.Tick += new System.EventHandler(this.timer_Tiempo);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // menuTemas
            // 
            resources.ApplyResources(this.menuTemas, "menuTemas");
            this.menuTemas.BackColor = System.Drawing.Color.White;
            this.menuTemas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuTemas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTemas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTema});
            this.menuTemas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuTemas.Name = "menuTemas";
            this.menuTemas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // btnTema
            // 
            this.btnTema.BackColor = System.Drawing.Color.Maroon;
            this.btnTema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOscuro,
            this.btnPlateado});
            this.btnTema.Name = "btnTema";
            resources.ApplyResources(this.btnTema, "btnTema");
            // 
            // btnOscuro
            // 
            this.btnOscuro.Name = "btnOscuro";
            resources.ApplyResources(this.btnOscuro, "btnOscuro");
            this.btnOscuro.Click += new System.EventHandler(this.oscuroToolStripMenuItem_Click);
            // 
            // btnPlateado
            // 
            this.btnPlateado.Name = "btnPlateado";
            resources.ApplyResources(this.btnPlateado, "btnPlateado");
            this.btnPlateado.Click += new System.EventHandler(this.plateadoToolStripMenuItem_Click);
            // 
            // temaForm
            // 
            this.temaForm.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.barraTitulo.Controls.Add(this.menuTemas);
            this.barraTitulo.Controls.Add(this.lblFecha);
            this.barraTitulo.Controls.Add(this.panel1);
            this.barraTitulo.Controls.Add(this.lblTime);
            this.barraTitulo.Controls.Add(this.panelBarra);
            this.barraTitulo.Controls.Add(this.btnMenuSlide);
            resources.ApplyResources(this.barraTitulo, "barraTitulo");
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.panelBarra, "panelBarra");
            this.panelBarra.Name = "panelBarra";
            // 
            // btnMenuSlide
            // 
            this.btnMenuSlide.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSlide.Image = global::MET.Properties.Resources.settingsSlider;
            resources.ApplyResources(this.btnMenuSlide, "btnMenuSlide");
            this.btnMenuSlide.Name = "btnMenuSlide";
            this.btnMenuSlide.TabStop = false;
            this.btnMenuSlide.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Red;
            this.panelCentro.BackgroundImage = global::MET.Properties.Resources.Logo;
            resources.ApplyResources(this.panelCentro, "panelCentro");
            this.panelCentro.Name = "panelCentro";
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Principal.IconOptions.Icon")));
            this.MainMenuStrip = this.menuTemas;
            this.Name = "Principal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuTemas.ResumeLayout(false);
            this.menuTemas.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel menuPrincipal;
        private System.Windows.Forms.PictureBox btnMenuSlide;
        public DevExpress.LookAndFeel.DefaultLookAndFeel temaForm;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.ToolStripMenuItem btnTema;
        private System.Windows.Forms.ToolStripMenuItem btnOscuro;
        private System.Windows.Forms.ToolStripMenuItem btnPlateado;
        private System.Windows.Forms.MenuStrip menuTemas;
        private System.Windows.Forms.Panel panel1;
    }
}

