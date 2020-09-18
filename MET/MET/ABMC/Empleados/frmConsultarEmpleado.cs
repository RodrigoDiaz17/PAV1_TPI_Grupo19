using BibliotecaDB.Entidades;
using BibliotecaMET.Clases.Form;
using BibliotecaMET.Clases.MetodosGenerales.Forms;
using BibliotecaMET.Controladores;
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
    public partial class frmConsultarEmpleado : AbstractForm
    {

        Empleado empleadoSeleccionado;
        public frmConsultarEmpleado()
        {
            InitializeComponent();
            Actualizar(base.Tema);
        }

        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            //barraTitulo.BackColor = Colors[0];
            //panelCentro.BackColor = Colors[1];
            this.BackColor = Colors[0];
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
            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                //Colors[0] = Color.FromArgb(238, 238, 242);
                //Colors[1] = Color.FromArgb(204, 206, 219);
                Colors[0] = Color.FromArgb(255, 255, 255);
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //botones
            btnCancelar.BackColor = Colors[0];
            btnFiltrar.BackColor = Colors[0];
            btnModificar.BackColor = Colors[0];
            btnBorrar.BackColor = Colors[0];
            //BotonesSobre
            btnCancelar.FlatAppearance.MouseOverBackColor = Colors[1];
            btnFiltrar.FlatAppearance.MouseOverBackColor = Colors[1];
            btnModificar.FlatAppearance.MouseOverBackColor = Colors[1];
            btnBorrar.FlatAppearance.MouseOverBackColor = Colors[1];
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

        private void AltaPersona_Load(object sender, EventArgs e)
        {

        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkFiltroXCampo_CheckedChanged(object sender, EventArgs e)
        {
            pnlFiltroCampo.Visible = chkFiltroXCampo.Checked;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbCampo.SelectedIndex == 0) { MetodosForms.OnlyIntergers(sender, e); }
        }

        private bool Validar()
        {
            bool resultado = true;
            int n;
            string mensaje = "";
            if (txtCampo1.Text.Equals("")) { mensaje += "\n-"+lblCampo1.Text+": vacio"; }
            if (cmbTipoEmpleado.SelectedItem.Equals(0)) { mensaje += "\n-Filtro segun estado: seleccione si desea ver los usuarios borrados"; }
            if (cmbCampo.SelectedItem.Equals(-1) && chkFiltroXCampo.Checked) { mensaje += "\n-Campos: seleccione uno o destilde el filtro por campo"; }
            if (cmbCampo.SelectedIndex.Equals(4) && txtCampo1.Text.Equals("")) { mensaje += "\n-Nombres: vacio"; }
            if (cmbCampo.SelectedIndex.Equals(2) && txtCampo1.Text.Equals("")) { mensaje += "\n-Nombres: vacio"; }
            if (cmbCampo.SelectedIndex.Equals(3) && txtCampo2.Text.Equals("")) { mensaje += "\n-Apellidos: vacio"; }
            if (cmbCampo.SelectedIndex.Equals(4) && txtCampo2.Text.Equals("")) { mensaje += "\n-Apellidos: vacio"; }
            if (cmbCampo.SelectedIndex.Equals(0) && (int.TryParse(txtCampo1.Text,out n))) { mensaje += "\n-DNI: no es posee un formato valido"; }


            if (!mensaje.Equals("")) { MessageBox.Show("Los siguientes campos están erroneos:" + mensaje, "Error"); resultado = false; }

            return resultado;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            pnlEmpleadoSeleccionado.Visible=false;
            switch (cmbTipoEmpleado.SelectedIndex)
            {
                case 0:
                    if (chkFiltroXCampo.Checked)
                    {
                        if (Validar())
                        {
                            switch (cmbCampo.SelectedIndex)
                            {
                                case 0:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosPorDni(Convert.ToInt32(txtCampo1.Text));
                                    break;
                                case 1:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosPorNombres(txtCampo1.Text);
                                    break;
                                case 2:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosPorApellido(txtCampo1.Text);
                                    break;
                                case 3:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosPorNombresYApellidos(txtCampo1.Text, txtCampo2.Text);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else 
                    {
                        gdrEmpleados.DataSource = ControladorEmpleados.ConsultarEmpleados();
                    }
                    break;
                case 1:
                    if (chkFiltroXCampo.Checked)
                    {
                        if (Validar())
                        {
                            switch (cmbCampo.SelectedIndex)
                            {
                                case 0:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosActivosPorDni(Convert.ToInt32(txtCampo1.Text));
                                    break;
                                case 1:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosActivosPorNombres(txtCampo1.Text);
                                    break;
                                case 2:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosActivosPorApellido(txtCampo1.Text);
                                    break;
                                case 3:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosActivosPorNombresYApellidos(txtCampo1.Text, txtCampo2.Text);
                                    break;
                                default:
                                    break;
                            }

                        }
                    }
                    else
                    {
                        gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosActivos();
                    }
                    break;
                case 2:
                    if (chkFiltroXCampo.Checked)
                    {
                        if (Validar())
                        {
                            switch (cmbCampo.SelectedIndex)
                            {
                                case 0:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosBorradosPorDni(Convert.ToInt32(txtCampo1.Text));
                                    break;
                                case 1:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosBorradosPorNombres(txtCampo1.Text);
                                    break;
                                case 2:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosBorradosPorApellido(txtCampo1.Text);
                                    break;
                                case 3:
                                    gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosBorradosPorNombresYApellidos(txtCampo1.Text, txtCampo2.Text);
                                    break;
                                default:
                                    break;
                            }

                        }
                    }
                    else
                    {
                        gdrEmpleados.DataSource = ControladorEmpleados.ConnsultarEmpleadosBorrados();
                    }
                    break;
                    
                default:
                    break;
            }
            ColorearFilas();
        }

        private void ColorearFilas() 
        {
            foreach (DataGridViewRow fila in gdrEmpleados.Rows)
            {
                if ((bool)fila.Cells["borrado"].Value) { fila.DefaultCellStyle.BackColor = Color.IndianRed; }
                else { fila.DefaultCellStyle.BackColor= Color.LightGreen; }
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmEliminarEmpleado ConfirmarBorrado = new frmEliminarEmpleado(empleadoSeleccionado.legajo);
            ConfirmarBorrado.Show();
        }

        private void CambiarEstadoPanel() 
        {
            if (pnlEmpleadoSeleccionado.Visible) { pnlEmpleadoSeleccionado.Visible = false; }
            else { pnlEmpleadoSeleccionado.Visible = true; }
        }

        private void gdrEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = gdrEmpleados.Rows[e.RowIndex];
            ParseToEmpleado(filaSeleccionada);
            txtLegajoSeleccionado.Text = empleadoSeleccionado.legajo.ToString();
            pnlEmpleadoSeleccionado.Visible = true;
        }

        private void ParseToEmpleado(DataGridViewRow filaSeleccionada) 
        {
            empleadoSeleccionado = new Empleado((int)filaSeleccionada.Cells["legajo"].Value, (int) filaSeleccionada.Cells["dni"].Value , filaSeleccionada.Cells["nombres"].Value.ToString() , filaSeleccionada.Cells["apellidos"].Value.ToString() , (int) filaSeleccionada.Cells["generoId"].Value, (DateTime) filaSeleccionada.Cells["fechaNacimiento"].Value , filaSeleccionada.Cells["correo"].Value.ToString() , filaSeleccionada.Cells["telefono"].Value.ToString() , filaSeleccionada.Cells["observaciones"].Value.ToString() , filaSeleccionada.Cells["instagram"].Value.ToString());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ( (frmPanelEmpleados) Contenedor.principal.GetCenterPanel().Controls[0]).AgregarFormAlPanelCentral(new frmModificarEmpleado(empleadoSeleccionado));
            
        }
        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    lblCampo1.Visible = txtCampo1.Visible = true;
                    lblCampo2.Visible = txtCampo2.Visible = false;
                    lblCampo1.Name = lblCampo1.Text = "Dni";
                    break;                                                 
                case 1:
                    lblCampo1.Visible = txtCampo1.Visible = true;
                    lblCampo2.Visible = txtCampo2.Visible = false; 
                    lblCampo1.Name = lblCampo1.Text = "Nombres";
                    break;                                                 
                case 2:
                    lblCampo1.Visible = txtCampo1.Visible = true;
                    lblCampo2.Visible = txtCampo2.Visible = false;
                    lblCampo1.Name = lblCampo1.Text = "Apellidos";
                    break;                                                 
                case 3:
                    lblCampo1.Visible = txtCampo1.Visible = true;
                    lblCampo2.Visible = txtCampo2.Visible = true;
                    lblCampo1.Name = lblCampo1.Text = "Nombres";
                    break;
                default:
                    break;
            }
    
        }
    }
}
