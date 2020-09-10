using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    public class Direccion
    {
        private int id;
        private string calle;
        private int numero;
        private int piso;
        private string departamento;
        private int barrio_id;
        private Barrio barrio;

        public Direccion(int id, string calle, int numero, int piso, string departamento, int barrio_id, string barrio_nombre)
        {
            this.id = id;
            this.calle = calle;
            this.numero = numero;
            this.piso = piso;
            this.departamento = departamento;
            if (barrio_id == -1) { this.barrio = new Barrio(); } else { this.barrio = new Barrio(barrio_id, barrio_nombre); }
        }
        public Direccion( string calle, int numero, int piso, string departamento, int barrio_id, string barrio_nombre):this(-1,calle, numero, piso, departamento, barrio_id, barrio_nombre)
        {
        }
        public Direccion(string calle, int numero) : this(calle, numero, -99, "Sin Depto", -1, "No importa") { }
        public Direccion():this("Sin Calle", -1, -99, "Sin Depto", -1, "No importa")
        {
            
        }


        public int Id { get => id; set => id = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Piso { get => piso; set => piso = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public Barrio Barrio { get => barrio; set => barrio = value; }
    }
}
