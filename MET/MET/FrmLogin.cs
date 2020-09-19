using BibliotecaDB.Acceso;
using BibliotecaDB.Entidades;
using BibliotecaMET.Controladores;
using MET;
using MET.Forms.Presentacion;
using MET.Paneles;
using MET.Paneles.Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET
{
    public partial class FrmLogin : Form
    {
        bool Lock = true;
        public FrmLogin()
        {
            InitializeComponent();
        }

       

        private void fullfield(TextBox txt)
        {
            if (txt.Text.Equals("") && txt.Name.Equals("txtUsuario"))
            {
                txt.Text = "Usuario";
            }

            if (txt.Text.Equals("") && txt.Name.Equals("txtContraseña"))
            {
                txt.Text = "Contraseña";
                txt.PasswordChar = '\0';
            }


        }

        private void clearField(TextBox txt)
        {
            if (txt.Text.Equals("Usuario")) { txt.Clear(); }
            
            if (txt.Text.Equals("Contraseña") )
            {
                txt.Clear();
                if (Lock)
                { txtContraseña.PasswordChar = '*'; }
                else
                { txtContraseña.PasswordChar = '\0'; }
            }
        }

        private void select(Panel panel, TextBox txt)
        {
            txt.ForeColor = Color.FromArgb(78, 184, 206);
            panel.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void unselect(Panel panel, TextBox txt)
        {
            txt.ForeColor = Color.WhiteSmoke;
            panel.BackColor = Color.WhiteSmoke;
        }

        private void gotFocus( TextBox txtFocused, TextBox txtAnother , Panel panelFoucused , Panel panelAnother )
        {
            fullfield(txtAnother);
            clearField(txtFocused);
            unselect(panelAnother, txtAnother);
            select(panelFoucused, txtFocused);
        }
        
        private void enviar()
        { 
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario.Equals("")) { MessageBox.Show("Ingrese un usuario primero", "Vuelva a intentarlo"); }
            else
            {
                if (contraseña.Equals("")) { MessageBox.Show("Ingrese una contraseña primero", "Vuelva a intentarlo"); }
                else
                {
                    try
                    {
                        List<object> resultado = ControladorLogin.Login(usuario, contraseña);
                        this.Hide();
                        bool exito = (bool)resultado[0];
                        if (exito)
                        {
                            Cuenta cuenta = (Cuenta)resultado[1];
                            Bienvenida presentacion = new Bienvenida(cuenta);
                            presentacion.ShowDialog();
                            Contenedor.principal = new Principal(cuenta);
                            Contenedor.principal.ShowDialog();
                            Contenedor.principal.Close();
                            this.Show();
                        }
                        else 
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrectos", "Vuelva a intentarlo");
                        }
                        
                    }
                    catch(Exception e)
                    {
                        { MessageBox.Show("Ha ocurrido un error al tratar de entrar a la base de datos, el error fué: " + e.Message , "ERROR"  ); }
                    }

                   
                }
            }
            this.Show(); this.txtContraseña.Text = "";
        }
        
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviar();
        }



        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            gotFocus(txtUsuario, txtContraseña, panelUsuario, panelContraseña );
        }

        private void btnLock_Click(object sender, MouseEventArgs e)
        {
            if (Lock) 
            {
                btnLock.Image = MET.Properties.Resources.UNLOCK;
                txtContraseña.PasswordChar = '\0';
                Lock = false;
            }
            else
            {
                btnLock.Image = MET.Properties.Resources.LOCK;
                txtContraseña.PasswordChar = '*';
                Lock = true;
            }
            
        }

     
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           // txtContraseña_Click(this, e);
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            gotFocus(txtContraseña, txtUsuario, panelContraseña, panelUsuario);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    txtContraseña.Focus();
                    gotFocus(txtContraseña, txtUsuario, panelContraseña, panelUsuario);
                    break;
                case Keys.Enter:
                    enviar();
                    break;
                default:
                    break;
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    txtUsuario.Focus();
                    gotFocus(txtUsuario, txtContraseña, panelUsuario, panelContraseña);
                    break;
                case Keys.Enter:
                    enviar();
                    break;
                default:
                    break;
            }
        }
    }
}
