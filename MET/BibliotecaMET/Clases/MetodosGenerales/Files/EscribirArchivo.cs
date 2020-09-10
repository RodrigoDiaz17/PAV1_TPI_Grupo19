using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BibliotecaMET.Clases.MetodosGenerales.Files

{
    public class EscribirArchivo
    {
        private bool generated = false;
        private string path;
        private string nombreCarpeta;
        private string nombreArchivo;
        private bool fecha;

        public EscribirArchivo(string nombreCarpeta, string nombreArchivo, bool fecha)
        {
            this.nombreCarpeta = nombreCarpeta;
            this.nombreArchivo = nombreArchivo;
            this.fecha = fecha;
        }
        public EscribirArchivo(string nombreCarpeta, string nombreArchivo):this(nombreCarpeta,nombreArchivo,false) {}
        public void generate()
        {
            //Crear path sub dir
            try
            {
               //Crear sub dir
            string directory = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory); //todos los escritorios
            string folder = nombreCarpeta;
            string folderPath = System.IO.Path.Combine(directory, folder);
            System.IO.Directory.CreateDirectory(folderPath);
               
                //crear path archivo
                string filename;
                if (fecha) { filename = String.Format(nombreArchivo + "{0:yyyy-MM-dd-hh-mm-ss}" + ".txt", DateTime.Now); }
                else { filename = nombreArchivo + ".txt"; }//cambia formato

                //conbina directoio con filename
                path = System.IO.Path.Combine(folderPath, filename);
                StreamWriter file = File.CreateText(path);
                file.Flush();
                file.Close();

                generated = true;
            }
            catch
            {
                generated = false;
                throw;
            }                  

        }
        public void overwrite(string x)
        {
            try
            {
                if (generated)
                {
                    File.WriteAllText(path, x);
                }
                else
                {
                    generate();
                    File.WriteAllText(path, x);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void write(Object x)
        {
            try
            {
                if (generated)
                {
                    StreamWriter file = File.AppendText(path);
                    file.WriteLine(x);
                    file.Flush();
                    file.Close();

                }
                else
                {
                    generate();
                    StreamWriter file = File.AppendText(path);
                    file.WriteLine(x);
                    file.Flush();
                    file.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }    
        }

    }
}