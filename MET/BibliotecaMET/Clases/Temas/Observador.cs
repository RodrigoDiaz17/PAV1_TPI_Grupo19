using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMET.Clases.Interfaces.Adaptadores;
using BibliotecaMET.Clases.Form;

namespace BibliotecaMET.Clases.Temas
{
    public class Observador : IObservador
    {
        private object form;

        public object Form { get => form; set => form = value; }

        public void Actualizar(object evento)
        { 
            if (evento.GetType() == typeof(string)) { ((AbstractForm)form).Actualizar(evento); }
            else if (form.GetType() == typeof(AbstractForm)) { ((AbstractForm)form).Actualizar(evento); }
        }
    }
}
