namespace MET
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelContraseña = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblLockPassword = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.PictureBox();
            this.btnLock = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(66, 157);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(264, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsuario.Location = new System.Drawing.Point(20, 186);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(345, 1);
            this.panelUsuario.TabIndex = 999999999;
            // 
            // panelContraseña
            // 
            this.panelContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContraseña.Location = new System.Drawing.Point(21, 246);
            this.panelContraseña.Name = "panelContraseña";
            this.panelContraseña.Size = new System.Drawing.Size(345, 1);
            this.panelContraseña.TabIndex = 999999999;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContraseña.Location = new System.Drawing.Point(63, 217);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(264, 23);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // lblLockPassword
            // 
            this.lblLockPassword.Font = new System.Drawing.Font("Arial", 7F);
            this.lblLockPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLockPassword.Location = new System.Drawing.Point(21, 250);
            this.lblLockPassword.Name = "lblLockPassword";
            this.lblLockPassword.Size = new System.Drawing.Size(348, 19);
            this.lblLockPassword.TabIndex = 99999999;
            this.lblLockPassword.Text = "Presione el candao si desea ver la contraseña";
            this.lblLockPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnX
            // 
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.Image = global::MET.Properties.Resources.LogoSaludPilates;
            this.btnX.Location = new System.Drawing.Point(348, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(24, 22);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnX.TabIndex = 8;
            this.btnX.TabStop = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(269, 361);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 100);
            this.btnEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLock
            // 
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLock.Image = global::MET.Properties.Resources.LOCK;
            this.btnLock.Location = new System.Drawing.Point(27, 210);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(30, 30);
            this.btnLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLock.TabIndex = 6;
            this.btnLock.TabStop = false;
            this.btnLock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLock_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(147, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(384, 473);
            this.Controls.Add(this.lblLockPassword);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panelContraseña);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContraseña;
        private System.Windows.Forms.PictureBox btnLock;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox btnEnviar;
        private System.Windows.Forms.PictureBox btnX;
        private System.Windows.Forms.Label lblLockPassword;
    }
}