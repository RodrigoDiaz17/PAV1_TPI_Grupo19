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

namespace MET.ABMC.Empleados
{
    public partial class frmModificarEmpleado : AbstractForm
    {
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gdrPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BibliotecaDB.Entidades.Empleados empleadoNuevo = new BibliotecaDB.Entidades.Empleados(Convert.ToInt32(txtNroDocumento.Text),
                txtNombre.Text, txtApellido.Text, Convert.ToInt32(comboBox1.SelectedItem), Convert.ToDateTime(txtFechaNacimiento.Text),
                txtCorreo.Text, txtTelefono.Text, txtObservaciones.Text, txtInstagram.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
