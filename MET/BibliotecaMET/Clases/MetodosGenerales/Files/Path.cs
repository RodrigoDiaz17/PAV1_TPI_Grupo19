using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Clases.MetodosGenerales.Files
{
    public class Path
    {
        public string combinarCarpetaArchivo(string nombreCarpeta, string nombreArchivo)
        {
            string directory = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory); //todos los escritorios
            string folder = nombreCarpeta;
            string folderPath = System.IO.Path.Combine(directory, folder);
            

            //conbina directoio con filename
            return System.IO.Path.Combine(folderPath, nombreArchivo+".txt");
            
        }
    }
}
