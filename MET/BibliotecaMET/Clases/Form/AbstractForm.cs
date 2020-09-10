using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Clases.Form
{
    public class AbstractForm: XtraForm //barraTitulo 45; 45; 48   panelCentro 28; 28; 28
    {
        //  private System.ComponentModel.IContainer components;
        private static string tema;

        protected string Tema { get => tema; set => tema = value; }

        //TEMAS

        //Set colores 
        protected virtual void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
        }
        //Ingresar colores - según tema
        protected virtual void AjustarFondos(string nombreTema)
        {
        }
        //Set colores 
        protected virtual void AjustarBotones(Color[] Colors)
        {
            //paneles
            
            //BotonesSobre
            
        }
        //Ingresar colores - según tema
        protected virtual void AjustarMenues(string nombreTema)
        {
        }
        //Indicar Tema - Principal       
        protected virtual void AjustarTemaPrincipal(string nombreTema)
        {
            AjustarFondos(nombreTema);
            AjustarMenues(nombreTema);
        }
        //Patron Observer / persistencia de tema
        public void CambiarTema(string nombreTema)
        {
            AjustarTemaPrincipal(nombreTema);
            //this.tema = nombreTema;
        }

        public void Actualizar(object evento)
        {
            if (evento.GetType() == typeof(string)) { CambiarTema((string)evento); }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AbstractForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AbstractForm";
            this.ResumeLayout(false);

        }
    }
}
