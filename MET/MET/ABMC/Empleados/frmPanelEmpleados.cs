using BibliotecaMET.Clases.Form;
using BibliotecaMET.Clases.Temas;
using DevExpress.XtraRichEdit.Model;
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

namespace MET.ABMC.Empleados
{
    public partial class frmPanelEmpleados : AbstractForm
    {
        static Form formActual;
        static short estado = 0;
        public frmPanelEmpleados()
        {
            InitializeComponent();
            Actualizar(base.Tema);
        }

        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            menuEmpleados.BackColor = Colors[0];
            PanelContenedor.BackColor = Colors[1];
        }
        //Ingresar colores - según tema
        protected override void AjustarFondos(string nombreTema)
        {
            Color[] Colors = new Color[2];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                //Colors[0] = Color.FromArgb(45, 45, 48);
                Colors[1] = Color.FromArgb(28, 28, 28);
                Colors[0] = Color.FromArgb(37, 37, 38);

            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                //Colors[0] = Color.FromArgb(238, 238, 242);
                Colors[1] = Color.FromArgb(204, 206, 219);
                Colors[0] = Color.FromArgb(255, 255, 255);
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //botones
            btnConsultarEmpleado.BackColor = Colors[0];
            btnRegistrarEmpleados.BackColor = Colors[0];
            btnSalir.BackColor = Colors[0];
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPanelEmpleados_Load(object sender, EventArgs e)
        {
        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            formActual = new frmConsultarEmpleado();
            AgregarFormAlPanelCentral(formActual);
        }

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            formActual =  new frmAltaEmpleado();
            AgregarFormAlPanelCentral(formActual);
        }

        public void AgregarFormAlPanelCentral(Form form) 
        {
            BibliotecaMET.Clases.MetodosGenerales.Forms.MetodosForms.AbrirFormEnPanel(form,PanelContenedor);
            Observador observador = new Observador(); observador.Form = form;
            Contenedor.principal.publicadorTema.RegristrarObservador(observador);
        }
    }
}