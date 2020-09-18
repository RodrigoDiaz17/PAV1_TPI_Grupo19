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
    public static class AccesoDBEmpleados
    {
        public static bool AltaEmpleado(Empleado empleado)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "AltaEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Dni", empleado.dni);
                cmd.Parameters.AddWithValue("@Nombres", empleado.nombres);
                cmd.Parameters.AddWithValue("@Apellido", empleado.apellidos);
                cmd.Parameters.AddWithValue("@GeneroId", empleado.id_genero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.fechanacimiento);
                if (empleado.correo.Equals("")) { cmd.Parameters.AddWithValue("@Correo", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Correo", empleado.correo); }
                if (empleado.telefono.Equals("")) { cmd.Parameters.AddWithValue("@Telefono", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Telefono", empleado.telefono); }
                if (empleado.instagram.Equals("")) { cmd.Parameters.AddWithValue("@Instagram", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Instagram", empleado.instagram); }
                if (empleado.observaciones.Equals("")) { cmd.Parameters.AddWithValue("@Observaciones", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Observaciones", empleado.observaciones); }
                
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

        public static bool ModificarEmpleado(Empleado empleado)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ModificarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Legajo", empleado.legajo);
                cmd.Parameters.AddWithValue("@Dni", empleado.dni);
                cmd.Parameters.AddWithValue("@Nombres", empleado.nombres);
                cmd.Parameters.AddWithValue("@Apellido", empleado.apellidos);
                cmd.Parameters.AddWithValue("@GeneroId", empleado.id_genero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleado.fechanacimiento);
                if (empleado.correo.Equals("")) { cmd.Parameters.AddWithValue("@Correo", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Correo", empleado.correo); }
                if (empleado.telefono.Equals("")) { cmd.Parameters.AddWithValue("@Telefono", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Telefono", empleado.telefono); }
                if (empleado.instagram.Equals("")) { cmd.Parameters.AddWithValue("@Instagram", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Instagram", empleado.instagram); }
                if (empleado.observaciones.Equals("")) { cmd.Parameters.AddWithValue("@Observaciones", DBNull.Value); }
                else { cmd.Parameters.AddWithValue("@Observaciones", empleado.observaciones); }

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

        public static bool BajaLogicaEmpleado(int Legajompleado)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BajaLogicaEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Legajo", Legajompleado);

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

        public static DataTable ConnsultarEmpleados()
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleados";
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
        public static DataTable ConnsultarEmpleadosPorDni(int dni)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
       
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosPorDni";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Dni", dni);


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
        public static DataTable ConnsultarEmpleadosPorApellido(string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
           

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);


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
        public static DataTable ConnsultarEmpleadosPorNombres(string nombres)
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres",nombres);


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
        public static DataTable ConnsultarEmpleadosPorNombresYApellidos(string nombres, string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosPorNombreYApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);

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
                      
        public static DataTable ConnsultarEmpleadosBorrados()
        {
            SqlConnection cn = ConexionDB.GetInstancia();
         
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosBorrados";
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
        public static DataTable ConnsultarEmpleadosBorradosPorDni(int dni)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosBorradosPorDni";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Dni", dni);


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
        public static DataTable ConnsultarEmpleadosBorradosPorApellido(string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
  

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosBorradosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);


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
        public static DataTable ConnsultarEmpleadosBorradosPorNombres(string nombres)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
           
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosBorradosPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", nombres);


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
        public static DataTable ConnsultarEmpleadosBorradosPorNombresYApellidos(string nombres, string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
         
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosBorradosPorNombreYApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);

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

        public static DataTable ConnsultarEmpleadosActivos()
        {
            SqlConnection cn = ConexionDB.GetInstancia();
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosActivos";
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
        public static DataTable ConnsultarEmpleadosActivosPorDni(int dni)
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosActivosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Dni", dni);


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
        public static DataTable ConnsultarEmpleadosActivosPorApellido(string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
       
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosActivosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);


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
        public static DataTable ConnsultarEmpleadosActivosPorNombres(string nombres)
        {
            SqlConnection cn = ConexionDB.GetInstancia();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosActivosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", nombres);


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
        public static DataTable ConnsultarEmpleadosActivosPorNombresYApellidos(string nombres, string apellidos)
        {
            SqlConnection cn = ConexionDB.GetInstancia();
          

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultarEmpleadosActivosPorApellido";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);

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
