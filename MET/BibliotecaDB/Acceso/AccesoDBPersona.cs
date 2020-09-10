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
    public partial class AccesoDBPersona
    {
        public static List<object> ConsultarGenero(int id) 
        {
            List<Object> resultado = new List<Object>();
            resultado.Add(false);
            SqlConnection cn = ConexionDB.GetInstancia();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultaGenero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                ConexionDB.Conectar();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    
                    string nombre=dr["nombre"].ToString();
                    resultado.Add(nombre);
                    resultado[0] = true;
                }
                
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
