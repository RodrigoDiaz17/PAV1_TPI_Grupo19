using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    public class Empleado 
    {
        public int legajo;
        public int dni;
        public string nombres;
        public string apellidos;
        public int id_genero;
        public DateTime fechanacimiento;
        public string correo;
        public string telefono;
        public string observaciones;
        public string instagram;

        public int Legajo { get => legajo; set => legajo = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Id_genero { get => id_genero; set => id_genero = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Instagram { get => instagram; set => instagram = value; }

        public Empleado(int legajo, int numerodocumento, string nombre, string apellido, int genero, DateTime fechanacimiento, string correo, string telefono, string observaciones, string instagram)
        {
            this.legajo = legajo;
            this.dni = numerodocumento;
            this.nombres = nombre;
            this.apellidos = apellido;
            this.id_genero = genero;
            this.fechanacimiento = fechanacimiento;
            this.correo = correo;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.instagram = instagram;
        }

        public Empleado(int numerodocumento, string nombre, string apellido, int genero, DateTime fechanacimiento, string correo, string telefono, string observaciones, string instagram):this(-1 , numerodocumento, nombre, apellido, genero, fechanacimiento, correo, telefono, observaciones, instagram)
        {
         //sin legajo   
        }
        
    }



}
