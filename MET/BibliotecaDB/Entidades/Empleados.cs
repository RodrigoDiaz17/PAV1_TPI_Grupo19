using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    class Empleados 
    {
        private int Especialidad;
        private string Cronograma;
        private int legajo;
        private int numerodocumento;
        private string nombre;
        private string apellido;
        private int genero_id;
        private string genero;
        private DateTime fechanacimiento;
        private int direccion_id;
        private string direccion;
        private string correo;
        private string telefono;
        private string observaciones;
        private string instagram;

        public Empleados(int especialidad, string cronograma, int legajo, int numerodocumento, string nombre, string apellido, int genero_id, string genero, DateTime fechanacimiento, int direccion_id, string direccion, string correo, string telefono, string observaciones, string instagram)
        {
            Especialidad = especialidad;
            Cronograma = cronograma;
            this.legajo = legajo;
            this.numerodocumento = numerodocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero_id = genero_id;
            this.genero = genero;
            this.fechanacimiento = fechanacimiento;
            this.direccion_id = direccion_id;
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.instagram = instagram;
        }

    }



}
