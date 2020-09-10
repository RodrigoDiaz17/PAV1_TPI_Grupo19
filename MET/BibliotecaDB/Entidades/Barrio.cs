using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    public class Barrio
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Barrio(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public Barrio() : this(-1,"Sin Barrio")
        {
        }
    }
}
