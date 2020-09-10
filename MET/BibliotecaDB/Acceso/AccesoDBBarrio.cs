using BibliotecaDB.Conexion;
using BibliotecaDB.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Acceso
{
    public class AccesoDBBarrio
    {
        public static DataTable ConsultarBarrios()
        {
            List<Object> resultado = new List<Object>();
            resultado.Add(false);
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarBarrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                ConexionDB.Conectar();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConexionDB.Desconectar(); ;
            }

        }

        public static bool AltaBarrio(Barrio barrio)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", barrio.Nombre);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                ConexionDB.Conectar();
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
                ConexionDB.Desconectar(); ;
            }
            return resultado;
        }
    }
    
}
