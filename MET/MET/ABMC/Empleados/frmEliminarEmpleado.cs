using BibliotecaMET.Clases.Form;
using BibliotecaMET.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET.ABMC.Empleados
{
    public partial class frmEliminarEmpleado : AbstractForm
    {
        int legajoDelEmpleado;
        public frmEliminarEmpleado(int legajo)
        {
            InitializeComponent();
            this.legajoDelEmpleado = legajo;
            Actualizar(base.Tema);
        }
     
        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            this.BackColor = Colors[0];
        }
        //Ingresar colores - según tema
        protected override void AjustarFondos(string nombreTema)
        {
            Color[] Colors = new Color[1];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
               Colors[0] = Color.FromArgb(37, 37, 38);
            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                Colors[0] = Color.FromArgb(255, 255, 255);
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //botones
            btnCancelar.BackColor = Colors[0];
            btnConfirmar.BackColor = Colors[0];
            //BotonesSobre
            btnCancelar.FlatAppearance.MouseOverBackColor = Colors[1];
            btnConfirmar.FlatAppearance.MouseOverBackColor = Colors[1];

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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ControladorEmpleados.BajaEmpleado(legajoDelEmpleado);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
