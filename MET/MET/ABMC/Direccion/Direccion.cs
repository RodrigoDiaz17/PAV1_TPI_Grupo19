using BibliotecaDB.Acceso;
using BibliotecaMET.Clases.Form;
using DevExpress.XtraPivotGrid.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET.ABMC.Direccion
{
    public partial class Direccion : AbstractForm
    {
        private BibliotecaDB.Entidades.Direccion ClaseDireccion = new BibliotecaDB.Entidades.Direccion();
        public ref BibliotecaDB.Entidades.Direccion GetDireccion() { return ref ClaseDireccion; }
        private bool paneles;

        public Direccion()
        {
            InitializeComponent();
            Actualizar(base.Tema);
        }
        private void Direccion_Load(object sender, EventArgs e)
        {
            CargarDatos() ; LimpiarCampos();
        }


        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
             this.BackColor = Colors[1];          
           
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
            //Botones
            btnAgregar.FlatAppearance.MouseOverBackColor = Colors[0];
            btnGuardar.FlatAppearance.MouseOverBackColor = Colors[0];
            btnLimpiarCampos.FlatAppearance.MouseOverBackColor = Colors[0];
            btnSeleccionar.FlatAppearance.MouseOverBackColor = Colors[0];
            //MouseDown
            btnAgregar.BackColor = Colors[1];
            btnGuardar.BackColor = Colors[1];
            btnLimpiarCampos.BackColor = Colors[1];
            btnSeleccionar.BackColor = Colors[1];
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
        //Indicar Tema - Principal       

        //Patron Observer / persistencia de tema


        public void CargarDatos()
        {
            CargarGrilla();
            CargarBarrios();
        }
        public void CargarBarrios() 
        {
            DataTable tabla = AccesoDBBarrio.ConsultarBarrios();
            cmbBarrio.DataSource = tabla;
            cmbBarrio.ValueMember = "id";
            cmbBarrio.ValueMember = "nombre";
            if(tabla.Rows.Count == 0) { cmbBarrio.Enabled = false; cmbBarrio.Text = "No hay barrios existentes"; }
        }
        public void CargarGrilla() 
        {
            gdrDirecciones.DataSource = AccesoDBDireccion.ConsultarDirecciones();
        }

        private void LimpiarCampos()
        {
            txtCalle.Text = "";
            txtPiso.Text = "";
            txtNumero.Text = "";
            txtPiso.Text = "";
            txtDepartamento.Text = "";
            cmbBarrio.SelectedIndex = -1;
            btnGuardar.Text = "Guardar Direccion";

        }

        private void EsDepartamento() 
        {
            if (chkbEsDepartamento.Checked)
            {
                panelDatosDepartamento.Visible = true;
                txtPiso.Text = "";
                txtDepartamento.Text = "";
            }
            else 
            {
                panelDatosDepartamento.Visible = false;
            }
        }

        private void gdrDirecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrDirecciones.Rows[indice];
                int id = (int)filaSeleccionada.Cells["id"].Value;
                List<object> resultado = AccesoDBDireccion.ConsultarDireccion(id);
                if ((bool)resultado[0])
                {
                    LimpiarCampos();
                    MostrarPaneles();
                    ClaseDireccion = (BibliotecaDB.Entidades.Direccion)resultado[1];
                    CargarDireccion();
                }
                else
                {
                    MessageBox.Show("No se ha podido cargar la persona con exito");
                }
            }
            catch (Exception a) 
            {
                MessageBox.Show("No se ha podido cargar la persona con exito"+ a.Message);
            }
        }

        private void CargarDireccion() 
        {
            txtCalle.Text = ClaseDireccion.Calle;
            txtNumero.Text = ClaseDireccion.Numero.ToString();
            CargarPanelDatos();
            cmbBarrio.SelectedIndex = ClaseDireccion.Barrio.Id;
            btnGuardar.Text = "Modificar Direccion";
        }
        
        private void CargarPanelDatos() 
        {
            if (ClaseDireccion.Departamento.ToString().Equals("--"))
            {
                panelDatosDepartamento.Visible = false;
                txtPiso.Text = "";
                txtPiso.Text = "";
            }
            else
            {
                panelDatosDepartamento.Visible = true;
                txtPiso.Text = ClaseDireccion.Piso.ToString();
                txtDepartamento.Text = ClaseDireccion.Departamento.ToString();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void chkbEsDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            EsDepartamento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCalle.Text.Equals("") || txtNumero.Text.Equals("")) 
            {
               MessageBox.Show("Datos imbalidos para cargar una direccion"); txtCalle.Focus();
            }
            else
            {
                if (chkbEsDepartamento.Checked)
                {
                    ClaseDireccion = (BibliotecaDB.Entidades.Direccion)new BibliotecaDB.Entidades.Direccion(txtCalle.Text, Convert.ToInt32(txtNumero.Text));
                   
                }
                else
                {
                    ClaseDireccion = (BibliotecaDB.Entidades.Direccion)new BibliotecaDB.Entidades.Direccion();
                }

            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void MostrarPaneles() 
        {
            if (!paneles) 
            {
                paneles = true;
                panelSeleccionar.Visible = true;
                panelBaja.Visible = true;
            }
            else
            {
                paneles = false;
                panelSeleccionar.Visible = false;
                panelBaja.Visible = false;
            }
            
        }
    }
}
