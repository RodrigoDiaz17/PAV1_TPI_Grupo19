using BibliotecaDB.Entidades;
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

namespace MET.Forms.Presentacion
{
    public partial class Bienvenida : Form
    {
        private Cuenta cuenta;
        private float count = 0;
        private float count2 = 0;
        private int countTxt = 0;
        private float countAux = 0;
        private int largo;
        private string txt;
        private int[] RGB=new int[3];
    


        public Bienvenida(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            lblBienvenido.Text += "  " + cuenta.Usuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (count == 100)
            {
                
                picCenter2.Image = MET.Properties.Resources.PostalTraking;
                picCenter.Image = MET.Properties.Resources.Basura;
                count2 += 0.5f;
                if (countTxt <= largo) { lblBienvenido.Text = txt.Substring(0, countTxt); }
                countAux +=0.5f ;
                if (countAux >= 1) { countTxt++; countAux = 0; }
                
                if (count2 >=10 && countTxt > largo)
                {
                    
                    timer1.Stop();
                    this.Refresh();
                    lblBienvenido2.Visible = true;
                    timerFade.Start();


                }
                
            }
            else
            {
                if (this.Opacity < 1) { this.Opacity += 0.01; }
                count += 0.5f;
                
                
            }

        }

        private void fadeIn()
        {
            if(RGB[0] > 169) { RGB[0] --; }
            if (RGB[0] < 169) { RGB[0]++; RGB[0]++; }
            if (RGB[1] > 169) { RGB[1]--; }
            if (RGB[1] < 169) { RGB[1]++; RGB[1]++; }
            if (RGB[2] > 169) { RGB[2]--; }
            if (RGB[2] < 169) { RGB[2]++; RGB[2]++; }

            lblBienvenido2.ForeColor = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
            if (RGB[0] == 169 && RGB[1] == 169 && RGB[2] == 169) 
            {
                timerFade.Stop();
                timer2.Start();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            

            if (this.Opacity <= 0)
            { 
                timer2.Stop();
                this.Refresh();
                
                this.Close();

            }
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            txt = "Que tengas un buen día";
            largo = txt.Length;
            RGB[0] = 32; RGB[1] = 47; RGB[2] = 66;
            lblBienvenido2.ForeColor = Color.FromArgb(34, 36, 49);
            lblGym.Text = cuenta.Usuario;

        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            fadeIn();
        }
    }
}
