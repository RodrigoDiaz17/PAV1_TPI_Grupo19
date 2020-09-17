using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMET.Clases.MetodosGenerales.Forms;
using BibliotecaMET.Clases.MetodosGenerales.Files;
using System.Reactive.Subjects;
using MET.Properties;
using BibliotecaMET.Clases.Temas;
using BibliotecaMET.Clases.Form;
using BibliotecaMET.Clases.Interfaces.Adaptadores;
using BibliotecaDB.Entidades;
using DevExpress.XtraPrinting.Native;
using MET.ABMC.Empleados;

namespace MET.Paneles
{
    public partial class Principal : AbstractForm
    {
        private Cuenta cuenta;
        public readonly Publicador publicadorTema = new Publicador();
        private int pw;
        private bool hide;
        private string nombreCarpeta = "Auxiliares";
        private string nombreArchivo = "TemaGuardado";

        
        public ref Panel GetLeftPanel()
        {
            return ref menuPrincipal;
        }

        public ref Panel GetCenterPanel()
        {
            return ref panelCentro;
        }


        //private readonly obs

        public Principal(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timerTiempo.Start();
            pw = menuPrincipal.Width;
            lblNombreUsuario.Text = cuenta.Usuario;
            string path = new Path().combinarCarpetaArchivo(nombreCarpeta, nombreArchivo);
            base.Tema = Settings.Default["Tema"].ToString();
            try
            {
                //CambiarTema(base.Tema);
                CambiarBarra();
                Actualizar(base.Tema);
            }
            catch(Exception) { }
            AbrirMenuPrincipal();
            //AbrirEnPanel(new frmEmpleado());
        }


        private void AbrirMenuPrincipal()
        {
            if (cuenta.TipoCuenta.Equals(1))
            {
                Paneles.MenuInicio.MenuInicioGimnasio menu = new Paneles.MenuInicio.MenuInicioGimnasio(cuenta);
                MetodosForms.AbrirFormEnPanel(menu,menuPrincipal);

                Observador observadorMenu = new Observador();
                observadorMenu.Form = (AbstractForm) menu;
                publicadorTema.RegristrarObservador(observadorMenu);
            }
            
        }

        public void AbrirEnPanel(Form form)
        {
            MetodosForms.AbrirFormEnPanel(form, panelCentro);
            Observador observadorMenu = new Observador();
            observadorMenu.Form = (AbstractForm) form;
            publicadorTema.RegristrarObservador(observadorMenu);
        }


        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            barraTitulo.BackColor = Colors[0];
          //  panelCentro.BackColor = Colors[1];
            menuPrincipal.BackColor = Colors[2];
        }
        //Ingresar colores - según tema
        protected override void AjustarFondos(string nombreTema)
        {
            Color[] Colors = new Color[3];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                Colors[0] = Color.FromArgb(45, 45, 48);
                Colors[1] = Color.FromArgb(28, 28, 28);
                Colors[2] = Color.FromArgb(37, 37, 38);
            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                Colors[0] = Color.FromArgb(238, 238, 242);
                Colors[1] = Color.FromArgb(204, 206, 219);
                Colors[2] = Color.FromArgb(255, 255, 255);
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //paneles
            btnTema.BackColor = Colors[1];
            btnOscuro.BackColor = Colors[1];
            btnPlateado.BackColor = Colors[1];
            menuTemas.BackColor = Colors[1];
            //BotonesSobre
            //btnTema.FlatAppearance.MouseOverBackColor = Colors[1];
            //btnOscuro.FlatAppearance.MouseOverBackColor = Colors[1];
            //btnPlateado.FlatAppearance.MouseOverBackColor = Colors[1];
            //MouseDown

        }
        //Ingresar colores - según tema
        protected override void AjustarMenues(string nombreTema)
        {
            Color[] Colors = new Color[3];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                Colors[0] = Color.FromArgb(27, 27, 28);
                Colors[1] = Color.FromArgb(51, 51, 52);
                Colors[2] = Color.FromArgb(45, 45, 48);

            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                Colors[0] = Color.FromArgb(246, 246, 246);
                Colors[1] = Color.FromArgb(201, 222, 245);
                Colors[2] = Color.FromArgb(28, 151, 234);
            }
            AjustarBotones(Colors);

        }
        //Indicar Tema - Principal       
        
    //Patron Observer / persistencia de tema
        
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //timerSlide.Start();
            if (hide)
            {
                menuPrincipal.Width = pw ;
                hide = false;
            }
            else
            {
                menuPrincipal.Width = 0;
                hide = true;
            }

        }

        private void timer_Tiempo(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

      

     
        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {
            RenovarTema("Visual Studio 2013 Dark");
        }

        private void btnTemaPlateado_Click(object sender, EventArgs e)
        {
            RenovarTema("Visual Studio 2013 Light");
        }

        private void RenovarTema(string nombreTema) 
        {
            /*MetodosForms.MostrarOcultarPanel(panelSettings);
            MetodosForms.MostrarOcultarPanel(panelTemas);*/
            GuardarTema(nombreTema);
            CambiarTema(nombreTema);
            CambiarBarra();
            publicadorTema.Notificar(nombreTema);
        }

        private void GuardarTema(string nombreTema) 
        {
            base.Tema = nombreTema;
            Settings.Default["Tema"] = nombreTema;
            Settings.Default.Save();
        }

        private void CambiarBarra()
        {
            temaForm.LookAndFeel.SkinName = base.Tema;
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenovarTema("Visual Studio 2013 Dark");
        }

        private void plateadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenovarTema("Visual Studio 2013 Light");
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
