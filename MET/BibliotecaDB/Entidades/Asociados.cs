using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    class Asociado : Persona
    {
        private int id;

        public Asociado (int id ,int tipoDocumento, int numeroDocumento, string nombre, string apellido, int genero_id, DateTime fechaNacimiento, int direccion_id, string correo, string telefono, string observaciones, string instagram) : base(tipoDocumento, numeroDocumento, nombre, apellido, genero_id, fechaNacimiento, direccion_id, correo, telefono, observaciones, instagram)
        {
            this.id = id;
        }
        
    }

}

