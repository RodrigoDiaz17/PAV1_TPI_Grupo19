using BibliotecaDB.Acceso;
using BibliotecaDB.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Controladores
{
    public partial class ControladorLogin
    {
        public static List<object> Login(string usuario, string contraseña)
        {
            List<object> resultado = new List<object>();
            resultado.Add(false);
            try
            {
                DataTable tabla = AccesoDBCuentas.Login(usuario, contraseña);
                if (tabla.Rows.Count == 1) 
                {
                    int id;
                    int tipoCuenta;
                    int gim_id;
                    int legajoEmpleado;

                    id = (int) tabla.Rows[0][0]; 
                    
                    // string usuario = (string) tabla.Rows[0][1];
                    tipoCuenta = (int)tabla.Rows[0][2];

                    if (tabla.Rows[0].IsNull(3) ) { gim_id = -1; }
                    else { gim_id = (int)tabla.Rows[0][3]; }

                    if (tabla.Rows[0].IsNull(4) ) { legajoEmpleado = -1; }
                    else {legajoEmpleado = (int)tabla.Rows[0][4];}
                    

                    Cuenta cuenta = new Cuenta(id,usuario,tipoCuenta,gim_id,legajoEmpleado);
                    resultado[0] = true;
                    resultado.Add(cuenta);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
