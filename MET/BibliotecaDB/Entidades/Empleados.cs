using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    class Empleados : Persona
    {
        private int Especialidad;
        private string Cronograma;
        private int legajo;

        public Empleados(int legajo, int tipoDocumento, int numeroDocumento, string nombre, string apellido, int genero_id, DateTime fechaNacimiento, int direccion_id, string correo, string telefono, string observaciones, string instagram) : base(tipoDocumento, numeroDocumento, nombre, apellido, genero_id, fechaNacimiento, direccion_id, correo, telefono, observaciones, instagram)
        {
            this.legajo = legajo;
        }

    }



}
