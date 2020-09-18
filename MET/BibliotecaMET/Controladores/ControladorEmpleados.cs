
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDB.Acceso;
using BibliotecaDB.Entidades;

namespace BibliotecaMET.Controladores
{
    public static class ControladorEmpleados
    {
        public static bool RegistrarEmpleado(Empleado empleado) 
        { 
            return AccesoDBEmpleados.AltaEmpleado(empleado); 
        }

        public static bool ModificarEmpleado(Empleado empleado) { return AccesoDBEmpleados.ModificarEmpleado(empleado); }

        public static bool BajaEmpleado(int legajoEmpleado) { return AccesoDBEmpleados.BajaLogicaEmpleado(legajoEmpleado); }

      

        public static DataTable ConsultarEmpleados()
        {
            return AccesoDBEmpleados.ConnsultarEmpleados();
        }

        public static DataTable ConnsultarEmpleadosPorDni(int dni)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivosPorDni( dni);
        }
        public static DataTable ConnsultarEmpleadosPorApellido(string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosPorApellido(apellidos);
        }
        public static DataTable ConnsultarEmpleadosPorNombres(string nombres)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosPorNombres(nombres);
        }
        public static DataTable ConnsultarEmpleadosPorNombresYApellidos(string nombres, string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosPorNombresYApellidos(nombres, apellidos);
        }

        public static DataTable ConnsultarEmpleadosBorrados()
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosBorrados();
        }
        public static DataTable ConnsultarEmpleadosBorradosPorDni(int dni)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosBorradosPorDni(dni);
        }
        public static DataTable ConnsultarEmpleadosBorradosPorApellido(string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosBorradosPorApellido(apellidos);
        }    
        public static DataTable ConnsultarEmpleadosBorradosPorNombres(string nombres)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosBorradosPorNombres(nombres);
        }
        public static DataTable ConnsultarEmpleadosBorradosPorNombresYApellidos(string nombres , string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosBorradosPorNombresYApellidos(nombres , apellidos);
        }

        public static DataTable ConnsultarEmpleadosActivos()
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivos();
        }
        public static DataTable ConnsultarEmpleadosActivosPorDni(int dni)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivosPorDni(dni);
        }
        public static DataTable ConnsultarEmpleadosActivosPorApellido(string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivosPorApellido(apellidos);
        }
        public static DataTable ConnsultarEmpleadosActivosPorNombres(string nombres)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivosPorNombres(nombres);
        }
        public static DataTable ConnsultarEmpleadosActivosPorNombresYApellidos(string nombres, string apellidos)
        {
            return AccesoDBEmpleados.ConnsultarEmpleadosActivosPorNombresYApellidos(nombres , apellidos);
        }

    }  
}
