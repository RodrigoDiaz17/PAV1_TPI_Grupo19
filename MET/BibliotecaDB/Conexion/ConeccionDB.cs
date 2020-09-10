using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Conexion
{
    public partial class ConexionDB
    {
        //declacaracion
        public static SqlConnection instancia;
        public static bool creada = false;
        // para no declararla si no se usa

        public static SqlConnection GetInstancia()
        {
            try
            {
                if (!creada) 
                {
                    creada = true;
                    string cadena = "Data Source=DESKTOP-LDHQLVB\\SQLEXPRESS;Initial Catalog=MET;Integrated Security=True";

                    instancia = new SqlConnection(cadena); }
                
                return instancia;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Conectar()
        {
            try
            {
                instancia.Open();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static void Desconectar()
        {
            try
            {
                instancia.Close();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
