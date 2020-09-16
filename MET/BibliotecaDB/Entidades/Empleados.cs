using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    public class Empleados 
    {
        private int numerodocumento;
        private string nombre;
        private string apellido;
        private int id_genero;
        private DateTime fechanacimiento;
        private string correo;
        private string telefono;
        private string observaciones;
        private string instagram;

        public Empleados(int numerodocumento, string nombre, string apellido, int genero, DateTime fechanacimiento, string correo, string telefono, string observaciones, string instagram)
        {
            this.numerodocumento = numerodocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id_genero = genero;
            this.fechanacimiento = fechanacimiento;
            this.correo = correo;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.instagram = instagram;
        }

    }



}
