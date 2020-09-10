using BibliotecaDB.Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    class Persona
    {
        private int tipodocumento;
        private int numerodocumento;
        private string nombre;
        private string apellido;
        private int genero_id;
        private string genero;
        private DateTime fechanacimiento;
        private int direccion_id;
        private Direccion direccion;
        private string correo;
        private string telefono;
        private string observaciones;
        private string instagram;


        public Persona(int tipoDocumento, int numeroDocumento, string nombre, string apellido, int genero_id, DateTime fechaNacimiento, int direccion_id, string correo, string telefono, string observaciones, string instagram)
        {
            this.tipodocumento = tipoDocumento;
            this.numerodocumento = numeroDocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero_id = genero_id;
            this.fechanacimiento = fechaNacimiento;
            this.direccion_id = direccion_id;
            this.correo = correo;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.instagram = instagram;
            CargarDireccionPersonal();
            CargarGenero();
        }

        public int Tipodocumento { get => tipodocumento; set => tipodocumento = value; }
        public int Numerodocumento { get => numerodocumento; set => numerodocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Genero_id { get => genero_id; set => genero_id = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public int Direccion_id { get => direccion_id; set => direccion_id = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Instagram { get => instagram; set => instagram = value; }
        internal Direccion Direccion { get => direccion; set => direccion = value; }

        public void CargarDireccionPersonal()
        {
            List<object> resultados = AccesoDBDireccion.ConsultarDireccion(direccion_id);
            if ((bool)resultados[0]) { direccion = (Direccion)resultados[1]; } 
        }
        public void CargarGenero()
        {
            List<object> resultados = AccesoDBPersona.ConsultarGenero(genero_id);
            if ((bool)resultados[0]) { genero = (string)resultados[1]; }
        }
    }
}
