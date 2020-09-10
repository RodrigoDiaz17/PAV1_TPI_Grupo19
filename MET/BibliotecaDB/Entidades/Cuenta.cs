using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDB.Entidades
{
    public class Cuenta
    {
        private int id;
        private string usuario;
        private int tipoCuenta;
        private int gim_id;
        private int legajoEmpleado;

        public Cuenta(int id, string usuario, int tipoCuenta, int gim_id, int legajoEmpleado)
        {
            this.id = id;
            this.usuario = usuario;
            this.tipoCuenta = tipoCuenta;
            this.gim_id = gim_id;
            this.legajoEmpleado = legajoEmpleado;
        }

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public int Gim_id { get => gim_id; set => gim_id = value; }
        public int LegajoEmpleado { get => legajoEmpleado; set => legajoEmpleado = value; }
    }
}
