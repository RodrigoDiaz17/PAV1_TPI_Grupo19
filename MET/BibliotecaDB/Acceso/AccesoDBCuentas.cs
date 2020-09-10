using BibliotecaDB.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Acceso
{
    public class AccesoDBCuentas
    {
         public static DataTable Login(string usuario, string contraseña)
         {


            //string cadena = "Data Source=DESKTOP-LDHQLVB\\SQLEXPRESS;Initial Catalog=MET;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(cadena);
            SqlConnection cn = ConexionDB.GetInstancia();
            try
            {
                SqlCommand comando = new SqlCommand();

                string consulta = "Login";

                comando.Parameters.Clear();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = consulta;

                ConexionDB.Conectar();

                comando.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                ConexionDB.Desconectar();
            }

          
            
        }
    }
}
