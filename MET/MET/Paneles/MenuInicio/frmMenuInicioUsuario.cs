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
    public partial class frmMenuInicioUsuario : AbstractForm
    {
        string usuario;
        public frmMenuInicioUsuario(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void CargarUsuario()
        {
            lblGimnasio.Text = usuario;
        }

        private void MenuPrincipalGimnasio_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTemaOscuro_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
