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
    public static class AccesoDBGenero
    {
        public static DataTable ConsultarGeneros()
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarGeneros";
                
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
    }
}
