using BibliotecaDB.Entidades;
using BibliotecaMET.Clases.Form;
using BibliotecaMET.Clases.MetodosGenerales.Forms;
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
    public partial class frmAltaEmpleado : AbstractForm
    {

        private bool Validar()
        {
            bool resultado = true;
            string mensaje = "";
            if (txtNombre.Text.Equals("")) { mensaje += "\n-Nombre: vacio"; }
            if (txtApellido.Text.Equals("")) { mensaje += "\n-Apellido: vacio"; }
            if (dtpFechaNacimiento.Value.Date==DateTime.Today.Date) { mensaje += "\n-Fecha Nacimiento: Identíca al día actual"; }
            if (!mensaje.Equals("")) { MessageBox.Show("Los siguientes campos están erroneos:" + mensaje, "Error"); resultado = false; }

            return resultado;
        }

        private void gdrPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                BibliotecaDB.Entidades.Empleados empleadoNuevo = new BibliotecaDB.Entidades.Empleados(Convert.ToInt32(txtNroDocumento.Text),
                txtNombre.Text, txtApellido.Text, Convert.ToInt32(comboBox1.SelectedItem), dtpFechaNacimiento.Value.Date,
                txtCorreo.Text, txtTelefono.Text, txtObservaciones.Text, txtInstagram.Text);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTopBtnArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottomBtnArea_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosForms.OnlyIntergers(sender, e);
        }
    }
}
