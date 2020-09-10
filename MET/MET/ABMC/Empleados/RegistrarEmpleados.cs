using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BibliotecaMET.Clases.Form;
using System.Data.SqlClient;



namespace MET
{
    public partial class altaEmpleados : AbstractForm
    {
        public altaEmpleados()
        {
            InitializeComponent();
        }
        /*

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {

                Empleados emp = ObtenerDatosEmpleados();

                bool resultado = AgregarEmpleadosABD(emp);

                if (resultado)
                {
                    MessageBox.Show("Empleado agregado con exito");
                }
                else
                {
                    MessageBox.Show("Error al agregar un Empleado");
                }
            }
        }

        private Empleados ObtenerDatosEmpleados()
        {
            Empleados emp = new Empleados();

            emp.NombreEmpleados = txtNombre.Text.Trim();

            emp.ApellidoEmpleados = txtApellido.Text.Trim();

            emp.DniEmpleados = txtDni.Text.Trim();

            emp.CalleEmpleados = txtCalle.Text.Trim();

            emp.NumeroEmpleados = txtNumero.Text.Trim();

            emp.TelefonoEmpleados = txtTelefono.Text.Trim();

            emp.MailEmpleados = txtMail.Text.Trim();

            emp.LegajoEmpleados = (int)legajo.SelectedValue;

            return emp;
        }

        private Empleados ObtenerEmpleados(string documento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleados p = new Empleados();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personas where NroDocumento like @documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.NombreEmpleados = dr["Nombre"].ToString();
                    p.ApellidoEmpleados = dr["Apellido"].ToString();
                    p.DniEmpleados = dr["NroDocumento"].ToString();
                    p.CalleEmpleados = dr["Calle"].ToString();
                    p.NumeroEmpleados = dr["Numero"].ToString();
                    p.TelefonoEmpleados = dr["Telefono"].ToString();
                    p.MailEmpleados = dr["Mail"].ToString();
                    p.LegajoEmpleados = int.Parse(dr["Legajo"].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return p;
        }

        private void AgregarEmpleados(Empleados, emp)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = emp.NombreEmpleados;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = emp.ApellidoEmpleados;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaDni = new DataGridViewTextBoxCell();
            celdaDni.Value = emp.DniEmpleados;
            fila.Cells.Add(celdaDni);

            DataGridViewTextBoxCell celdaTelefono = new DataGridViewTextBoxCell();
            celdaTelefono.Value = emp.TelefonoEmpleados;
            fila.Cells.Add(celdaTelefono);

            DataGridViewTextBoxCell celdaPlan = new DataGridViewTextBoxCell();
            celdaPlan.Value = emp.PlanAmpleados;
            fila.Cells.Add(celdaPlan);

            gdrEmpleados.Rows.Add(fila);

            MessageBox.Show("Empleado Agregada con exito");


        } */

    }

}
   