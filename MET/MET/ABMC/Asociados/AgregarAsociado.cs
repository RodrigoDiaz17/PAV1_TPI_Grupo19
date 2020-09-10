using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BibliotecaMET.Clases.Form;

namespace MET
{
    public partial class altaAsociado : AbstractForm
    {
        public altaAsociado()
        {
            InitializeComponent();
        }

        /* private void btnAgregar_Click(object sender, EventArgs e)
         {
             Asociados aso = ObtenerDatosAsociados();

             bool resultado = AgregarAsociadosABD(aso);

             if(resultado)
             {
                 MessageBox.Show("Asociado agregado con exito");
             }
             else
             {
                 MessageBox.Show("Error al agregar persona");
             }




         }

         private Asociados ObtenerDatosAsociados()
         {
             Asociados aso = new Asociados();

             aso.NombreAsociados = txtNombre.Text.Trim();

             aso.ApellidoAsociados = txtApellido.Text.Trim();

             aso.DniAsociados = txtDni.Text.Trim();

             aso.CalleAsociados = txtCalle.Text.Trim();

             aso.NumeroAsociados = txtNumero.Text.Trim();

             aso.TelefonoAsociados = txtTelefono.Text.Trim();

             aso.MailAsociados = txtMail.Text.Trim();

             aso.PlanAsociados = (int)cmbPlan.SelectedValue;

             return aso;
         }

         private Asociados ObtenerAsociados(string documento)
         {
             string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
             SqlConnection cn = new SqlConnection(cadenaConexion);
             Asociados p = new Asociados();
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
                     p.NombreAsociados = dr["Nombre"].ToString();
                     p.ApellidoAsociados = dr["Apellido"].ToString();
                     p.DniAsociados = dr["NroDocumento"].ToString();
                     p.CalleAsociados = dr["Calle"].ToString();
                     p.NumeroAsociados = dr["Numero"].ToString();
                     p.TelefonoAsociados = dr["Telefono"].ToString();
                     p.MailAsociados =dr["Mail"].ToString();
                     p.PlanAsociados =int.Parse(dr["Plan"].ToString());

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


         private bool AgregarAsociadosABD(Asociados aso)
         {
             string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
             SqlConnection cn = new SqlConnection(cadenaConexion);
             bool resultado = false;
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 string consulta = "INSERT INTO asociados(Nombre,Apellido,Dni,Calle,Numero,Telefono,Mail,Plan) " +
                     "VALUES(@nombre,@apellido,@Dni,@calle,@Numero,@Telefono,@Mail,@Plan)";
                 cmd.Parameters.Clear();
                 cmd.Parameters.AddWithValue("@Nombre", aso.NombreAsociados);
                 cmd.Parameters.AddWithValue("@Apellido", aso.ApellidoAsociados);
                 cmd.Parameters.AddWithValue("@Dni", aso.DniAsociados);
                 cmd.Parameters.AddWithValue("@Calle", aso.CalleAsociados);
                 cmd.Parameters.AddWithValue("@Numero", aso.NumeroAsociados);
                 cmd.Parameters.AddWithValue("@Telefono", aso.TelefonoAsociados);
                 cmd.Parameters.AddWithValue("@Mail", aso.MailAsociados);
                 cmd.Parameters.AddWithValue("@Plan", aso.PlanAsociados);
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = consulta;

                 cn.Open();
                 cmd.Connection = cn;
                 cmd.ExecuteNonQuery();
                 resultado = true;
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 cn.Close();
             }

             return resultado;
         }

         private bool ActualizarAsociados(Asociados aso)
         {

             string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
             SqlConnection cn = new SqlConnection(cadenaConexion);
             bool resultado = false;
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 string consulta = "UPDATE personas SET Nombre = (@nombre,@apellido,@Dni,@calle,@Numero,@Telefono,@Mail,@Plan WHERE NroDocumento like @nroDocumento";
                 cmd.Parameters.Clear();
                 cmd.Parameters.Clear();
                 cmd.Parameters.AddWithValue("@Nombre", aso.NombreAsociados);
                 cmd.Parameters.AddWithValue("@Apellido", aso.ApellidoAsociados);
                 cmd.Parameters.AddWithValue("@Dni", aso.DniAsociados);
                 cmd.Parameters.AddWithValue("@Calle", aso.CalleAsociados);
                 cmd.Parameters.AddWithValue("@Numero", aso.NumeroAsociados);
                 cmd.Parameters.AddWithValue("@Telefono", aso.TelefonoAsociados);
                 cmd.Parameters.AddWithValue("@Mail", aso.MailAsociados);
                 cmd.Parameters.AddWithValue("@Plan", aso.PlanAsociados);
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = consulta;

                 cn.Open();
                 cmd.Connection = cn;
                 cmd.ExecuteNonQuery();
                 resultado = true;
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 cn.Close();
             }

             return resultado;

         }


         private void AgregarAsociados(Asociados aso)
         {
             DataGridViewRow fila = new DataGridViewRow();

             DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
             celdaNombre.Value = aso.NombreAsociados;
             fila.Cells.Add(celdaNombre);

             DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
             celdaApellido.Value = aso.ApellidoAsociados;
             fila.Cells.Add(celdaApellido);

             DataGridViewTextBoxCell celdaDni = new DataGridViewTextBoxCell();
             celdaDni.Value = aso.DniAsociados;
             fila.Cells.Add(celdaDni);

             DataGridViewTextBoxCell celdaTelefono = new DataGridViewTextBoxCell();
             celdaTelefono.Value = aso.TelefonoAsociados;
             fila.Cells.Add(celdaTelefono);

             DataGridViewTextBoxCell celdaPlan = new DataGridViewTextBoxCell();
             celdaPlan.Value = aso.PlanAsociados;
             fila.Cells.Add(celdaPlan);

             gdrAsociados.Rows.Add(fila);

             MessageBox.Show("Persona Agregada con exito");


         }

         private void btnLimpiar_Click(object sender, EventArgs e)
         {

             LimpiarCampos();

         }

         private void LimpiarCampos()
             {
                 txtNombre.Clear();
                 txtApellido.Clear();
                 txtDni.Clear();
                 txtCalle.Clear();
                 txtNumero.Clear();
                 txtTelefono.Clear();
                 txtMail.Clear();

         }



         private void btnActualizarAsociados_Click(object sender, EventArgs e)
         {

            Asociados aso = ObtenerDatosAsociados();

            bool resultado = ActualizarAsociados(aso);
            if (resultado)
            {
               MessageBox.Show("Persona actualizada con exito");
               LimpiarCampos();
            }
            else
            {
               MessageBox.Show("Error al actualizar persona");

            }
         }


     */


    }
}
