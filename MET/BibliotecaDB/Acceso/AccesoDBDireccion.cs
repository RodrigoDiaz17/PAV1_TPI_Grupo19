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
    public partial class AccesoDBDireccion
    {
        public static List<object> ConsultarDireccion(int direccion_id) 
        {
            List<Object> resultado = new List<Object>();
            resultado.Add(false);
            SqlConnection cn = ConexionDB.GetInstancia();
            Direccion direccion;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultaDireccionCompleta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", direccion_id);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                ConexionDB.Conectar();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    
                    string calle = dr["D.calle"].ToString();
                    int numero = (int) dr["D.numeroCalle"];
                    int piso = (int) dr["D.piso"];
                    string departamento = dr["D.departamento"].ToString();
                    int barrio_id;
                    if (!dr["D.barrio_id"].Equals(null)) { barrio_id = -1; } else { barrio_id = (int)dr["D.barrio_id"]; }
                    string barrio_nombre;
                    if (!dr["B.nombre"].Equals(null)) { barrio_nombre = "No tiene"; } else { barrio_nombre = dr["B.nombre"].ToString(); }


                    direccion = new Direccion(direccion_id, calle, numero, piso, departamento, barrio_id, barrio_nombre);
                    resultado.Add(direccion);
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

        public static DataTable ConsultarDirecciones()
        {
            List<Object> resultado = new List<Object>();
            resultado.Add(false);
            SqlConnection cn = ConexionDB.GetInstancia();
       
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultaDireccionesCompletas";
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

        public static bool AltaDireccionCasaSinBarrio(Direccion direccion) 
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaDireccionCasaSinBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@calle", direccion.Calle);
                cmd.Parameters.AddWithValue("@numeroCalle", direccion.Numero);
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

        public static bool AltaDireccionCasa(Direccion direccion)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaDireccionCasa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@calle", direccion.Calle);
                cmd.Parameters.AddWithValue("@numeroCalle", direccion.Numero);
                cmd.Parameters.AddWithValue("@barrio_id", direccion.Barrio.Id);
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

        public static bool AltaDireccionDepartamento(Direccion direccion)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaDireccionDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@calle", direccion.Calle);
                cmd.Parameters.AddWithValue("@numeroCalle", direccion.Numero);
                cmd.Parameters.AddWithValue("@piso", direccion.Piso);
                cmd.Parameters.AddWithValue("@departamento", direccion.Departamento);
                cmd.Parameters.AddWithValue("@barrio_id", direccion.Barrio.Id);
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

        public static bool AltaDireccionDepartamentoSinBarrio(Direccion direccion)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaDireccionDepartamentoSinBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@calle", direccion.Calle);
                cmd.Parameters.AddWithValue("@numeroCalle", direccion.Numero);
                cmd.Parameters.AddWithValue("@piso", direccion.Piso);
                cmd.Parameters.AddWithValue("@departamento", direccion.Departamento);

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
