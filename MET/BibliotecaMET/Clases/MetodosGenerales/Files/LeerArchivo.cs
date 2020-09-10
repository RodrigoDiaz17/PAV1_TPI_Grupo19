using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Clases.MetodosGenerales.Files 
{ 
    public class LeerArchivo
    {
        string direccion;
        public LeerArchivo(string direccion)
        {
            this.direccion = direccion;
        }

        public List<string> LeerHasta(int ultimaLinea)
        {
            List<string> lista = new List<string>();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(direccion);
                try
                {
                    int counter=0;
                    string line;
                    while ((line = file.ReadLine()) != null && counter < ultimaLinea)
                    {
                        lista.Add(line);
                        counter++;
                    }                   
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    file.Close();
                }
                
            }
            catch(Exception)
            {
                throw;
            }
            return lista;



        }

        public string LeerUltimaLinea()

        {
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(direccion);
                try
                {
                    while ((line = file.ReadLine()) != null)
                    {
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    file.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return line;
        }

        public string LeerPrimeraLinea()

        {
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(direccion);
                try
                {
                    line = file.ReadLine();
                   /*
                   while ((line = file.ReadLine())!= null)
                   {
                        break;
                   }
                   */
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    file.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return line;



        }
    }
}
