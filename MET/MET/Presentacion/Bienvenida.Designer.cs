namespace MET.Forms.Presentacion
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.picRehabilitacion = new System.Windows.Forms.PictureBox();
            this.picRunning = new System.Windows.Forms.PictureBox();
            this.lblGym = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picYoga = new System.Windows.Forms.PictureBox();
            this.picPilates = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblBienvenido2 = new System.Windows.Forms.Label();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.picCenter2 = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRehabilitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.BarraTitulo.Controls.Add(this.picRehabilitacion);
            this.BarraTitulo.Controls.Add(this.picRunning);
            this.BarraTitulo.Controls.Add(this.lblGym);
            this.BarraTitulo.Controls.Add(this.lblTitulo);
            this.BarraTitulo.Controls.Add(this.picYoga);
            this.BarraTitulo.Controls.Add(this.picPilates);
            this.BarraTitulo.Controls.Add(this.Logo);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1025, 100);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // picRehabilitacion
            // 
            this.picRehabilitacion.Image = global::MET.Properties.Resources.LogoRehabilitacion;
            this.picRehabilitacion.Location = new System.Drawing.Point(975, 48);
            this.picRehabilitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRehabilitacion.Name = "picRehabilitacion";
            this.picRehabilitacion.Size = new System.Drawing.Size(50, 50);
            this.picRehabilitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRehabilitacion.TabIndex = 0;
            this.picRehabilitacion.TabStop = false;
            // 
            // picRunning
            // 
            this.picRunning.Image = global::MET.Properties.Resources.LogoRunnig;
            this.picRunning.Location = new System.Drawing.Point(975, 2);
            this.picRunning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRunning.Name = "picRunning";
            this.picRunning.Size = new System.Drawing.Size(50, 50);
            this.picRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRunning.TabIndex = 1;
            this.picRunning.TabStop = false;
            // 
            // lblGym
            // 
            this.lblGym.AutoSize = true;
            this.lblGym.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGym.Location = new System.Drawing.Point(654, 68);
            this.lblGym.Name = "lblGym";
            this.lblGym.Size = new System.Drawing.Size(75, 17);
            this.lblGym.TabIndex = 4;
            this.lblGym.Text = "GIMNASIO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Location = new System.Drawing.Point(141, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MET Río Cuarto";
            // 
            // picYoga
            // 
            this.picYoga.Image = global::MET.Properties.Resources.picYoga;
            this.picYoga.Location = new System.Drawing.Point(925, 48);
            this.picYoga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picYoga.Name = "picYoga";
            this.picYoga.Size = new System.Drawing.Size(50, 50);
            this.picYoga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYoga.TabIndex = 3;
            this.picYoga.TabStop = false;
            // 
            // picPilates
            // 
            this.picPilates.Image = global::MET.Properties.Resources.LogoSaludPilates;
            this.picPilates.Location = new System.Drawing.Point(925, 1);
            this.picPilates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPilates.Name = "picPilates";
            this.picPilates.Size = new System.Drawing.Size(50, 50);
            this.picPilates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPilates.TabIndex = 2;
            this.picPilates.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::MET.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(12, 5);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(112, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBienvenido.Location = new System.Drawing.Point(282, 131);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(342, 58);
            this.lblBienvenido.TabIndex = 9;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // lblBienvenido2
            // 
            this.lblBienvenido2.AutoSize = true;
            this.lblBienvenido2.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido2.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBienvenido2.Location = new System.Drawing.Point(281, 268);
            this.lblBienvenido2.Name = "lblBienvenido2";
            this.lblBienvenido2.Size = new System.Drawing.Size(561, 64);
            this.lblBienvenido2.TabIndex = 10;
            this.lblBienvenido2.Text = "Disfruta al máximo";
            this.lblBienvenido2.Visible = false;
            // 
            // timerFade
            // 
            this.timerFade.Interval = 10;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // picCenter2
            // 
            this.picCenter2.BackColor = System.Drawing.Color.Transparent;
            this.picCenter2.Image = global::MET.Properties.Resources.Aniversario;
            this.picCenter2.Location = new System.Drawing.Point(237, 341);
            this.picCenter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCenter2.Name = "picCenter2";
            this.picCenter2.Size = new System.Drawing.Size(213, 160);
            this.picCenter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCenter2.TabIndex = 8;
            this.picCenter2.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.BackColor = System.Drawing.Color.Transparent;
            this.picCenter.Image = global::MET.Properties.Resources.Montaña;
            this.picCenter.Location = new System.Drawing.Point(794, 341);
            this.picCenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(219, 160);
            this.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCenter.TabIndex = 7;
            this.picCenter.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Image = global::MET.Properties.Resources.PanelCotadoSinFondo;
            this.picLeft.Location = new System.Drawing.Point(0, 95);
            this.picLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(268, 421);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 0;
            this.picLeft.TabStop = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1025, 512);
            this.Controls.Add(this.lblBienvenido2);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.picCenter2);
            this.Controls.Add(this.picCenter);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.picLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRehabilitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPilates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox picRehabilitacion;
        private System.Windows.Forms.PictureBox picRunning;
        private System.Windows.Forms.PictureBox picPilates;
        private System.Windows.Forms.PictureBox picYoga;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.Label lblGym;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblBienvenido2;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.PictureBox picCenter2;
    }
}

