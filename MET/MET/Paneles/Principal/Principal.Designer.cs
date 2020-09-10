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
            this.btnMenuSlide = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.panelTemas = new System.Windows.Forms.Panel();
            this.btnTemaPlateado = new System.Windows.Forms.Button();
            this.btnTemaOscuro = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnTemas = new System.Windows.Forms.Button();
            this.picCenterLogo = new System.Windows.Forms.PictureBox();
            this.menuPrincipal = new System.Windows.Forms.Panel();
            this.temaForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panelBarraTitleTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelCentro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.panelTemas.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterLogo)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.panelBarraTitleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
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
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = global::MET.Properties.Resources.dupa_engranaje;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.Ivory;
            this.lblTime.Name = "lblTime";
            // 
            // lblNombreUsuario
            // 
            resources.ApplyResources(this.lblNombreUsuario, "lblNombreUsuario");
            this.lblNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
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
            // panelTemas
            // 
            resources.ApplyResources(this.panelTemas, "panelTemas");
            this.panelTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panelTemas.Controls.Add(this.btnTemaPlateado);
            this.panelTemas.Controls.Add(this.btnTemaOscuro);
            this.panelTemas.Name = "panelTemas";
            // 
            // btnTemaPlateado
            // 
            this.btnTemaPlateado.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaPlateado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemaPlateado.FlatAppearance.BorderSize = 0;
            this.btnTemaPlateado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            resources.ApplyResources(this.btnTemaPlateado, "btnTemaPlateado");
            this.btnTemaPlateado.Name = "btnTemaPlateado";
            this.btnTemaPlateado.UseVisualStyleBackColor = false;
            this.btnTemaPlateado.Click += new System.EventHandler(this.btnTemaPlateado_Click);
            // 
            // btnTemaOscuro
            // 
            this.btnTemaOscuro.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaOscuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemaOscuro.FlatAppearance.BorderSize = 0;
            this.btnTemaOscuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            resources.ApplyResources(this.btnTemaOscuro, "btnTemaOscuro");
            this.btnTemaOscuro.Name = "btnTemaOscuro";
            this.btnTemaOscuro.UseVisualStyleBackColor = false;
            this.btnTemaOscuro.Click += new System.EventHandler(this.btnTemaOscuro_Click);
            // 
            // panelSettings
            // 
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panelSettings.Controls.Add(this.btnTemas);
            this.panelSettings.Name = "panelSettings";
            // 
            // btnTemas
            // 
            this.btnTemas.BackColor = System.Drawing.Color.Transparent;
            this.btnTemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            resources.ApplyResources(this.btnTemas, "btnTemas");
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.UseVisualStyleBackColor = false;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // picCenterLogo
            // 
            resources.ApplyResources(this.picCenterLogo, "picCenterLogo");
            this.picCenterLogo.Image = global::MET.Properties.Resources.Logo;
            this.picCenterLogo.Name = "picCenterLogo";
            this.picCenterLogo.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // temaForm
            // 
            this.temaForm.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.barraTitulo.Controls.Add(this.panelBarraTitleTop);
            this.barraTitulo.Controls.Add(this.panelBarra);
            this.barraTitulo.Controls.Add(this.btnSettings);
            this.barraTitulo.Controls.Add(this.btnMenuSlide);
            resources.ApplyResources(this.barraTitulo, "barraTitulo");
            this.barraTitulo.Name = "barraTitulo";
            // 
            // panelBarraTitleTop
            // 
            this.panelBarraTitleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelBarraTitleTop.Controls.Add(this.pictureBox1);
            this.panelBarraTitleTop.Controls.Add(this.lblUsuario);
            resources.ApplyResources(this.panelBarraTitleTop, "panelBarraTitleTop");
            this.panelBarraTitleTop.Name = "panelBarraTitleTop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MET.Properties.Resources.TripleBarraAzul;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.panelBarra, "panelBarra");
            this.panelBarra.Name = "panelBarra";
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelCentro.Controls.Add(this.lblNombreUsuario);
            this.panelCentro.Controls.Add(this.panelTemas);
            this.panelCentro.Controls.Add(this.panelSettings);
            this.panelCentro.Controls.Add(this.lblTime);
            this.panelCentro.Controls.Add(this.picCenterLogo);
            this.panelCentro.Controls.Add(this.lblFecha);
            resources.ApplyResources(this.panelCentro, "panelCentro");
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentro_Paint);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Principal.IconOptions.Icon")));
            this.Name = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.panelTemas.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCenterLogo)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.panelBarraTitleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel menuPrincipal;
        private System.Windows.Forms.PictureBox picCenterLogo;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnMenuSlide;
        private System.Windows.Forms.Panel panelTemas;
        private System.Windows.Forms.Button btnTemaPlateado;
        private System.Windows.Forms.Button btnTemaOscuro;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnTemas;
        public DevExpress.LookAndFeel.DefaultLookAndFeel temaForm;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelBarraTitleTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelCentro;
    }
}

