﻿using BibliotecaDB.Entidades;
using BibliotecaMET.Clases.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET.Paneles.MenuInicio
{
    public partial class MenuInicioGimnasio : AbstractForm
    {
        Cuenta cuenta;
        public MenuInicioGimnasio(Cuenta cuenta )
        {
            InitializeComponent();
            this.cuenta = cuenta;
            Actualizar(base.Tema);
        }

        private void CargarUsuario()
        {
            lblGimnasio.Text = cuenta.Usuario;
        }

        private void MenuPrincipalGimnasio_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            //barraTitulo.BackColor = Colors[0];
            //panelCentro.BackColor = Colors[1];
            menuPrincipal.BackColor = Colors[0];
        }
        //Ingresar colores - según tema
        protected override void AjustarFondos(string nombreTema)
        {
            Color[] Colors = new Color[1];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                //Colors[0] = Color.FromArgb(45, 45, 48);
                //Colors[1] = Color.FromArgb(28, 28, 28);
                Colors[0] = Color.FromArgb(37, 37, 38);
                lblGimnasio.ForeColor = Color.White;
            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                //Colors[0] = Color.FromArgb(238, 238, 242);
                //Colors[1] = Color.FromArgb(204, 206, 219);
                Colors[0] = Color.FromArgb(255, 255, 255);
                lblGimnasio.ForeColor = Color.Black;
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //botones
            btnArea.BackColor = Colors[0];
            btnEmpleados.BackColor = Colors[0];
            btnAsociados.BackColor = Colors[0];
            btnGimnasio.BackColor = Colors[0];
            //BotonesSobre
            btnArea.FlatAppearance.MouseOverBackColor = Colors[1];
            btnEmpleados.FlatAppearance.MouseOverBackColor = Colors[1];
            btnAsociados.FlatAppearance.MouseOverBackColor = Colors[1];
            btnGimnasio.FlatAppearance.MouseOverBackColor = Colors[1];

        }
        //Ingresar colores - según tema
        protected override void AjustarMenues(string nombreTema)
        {
            Color[] Colors = new Color[2];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                Colors[0] = Color.FromArgb(27, 27, 28);
                Colors[1] = Color.FromArgb(51, 51, 52);

            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                Colors[0] = Color.FromArgb(246, 246, 246);
                Colors[1] = Color.FromArgb(201, 222, 245);
            }
            AjustarBotones(Colors);

        }

        private void panelTopBtnEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottomBtnEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void panelTopBtnAsociados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottomBtnAsociados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAsociados_Click(object sender, EventArgs e)
        {

        }

        private void panelTopBtnArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottomBtnArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
