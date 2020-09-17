using BibliotecaMET.Clases.Interfaces.Adaptadores;
using BibliotecaMET.Clases.Temas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Clases.Temas
{
    public  class Publicador : IPublicador
    {
        private readonly List<IObservador> observadores;

        public Publicador()
        {
            observadores = new List<IObservador>();
        }

        public void RegristrarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void QuitarObservador(System.Windows.Forms.Form form)
        {
            foreach (IObservador obs in observadores)
            {
                if(((Observador)obs).Form.Equals(form))
                observadores.Remove(obs);
            }
        }

        public void Notificar(IPublicador publicador)
        {
            foreach (IObservador observador in observadores)
            {
                observador.Actualizar(publicador);
            }
        }
        
        public void Notificar(object evento)
        {
            foreach (IObservador observador in observadores)
            {
                observador.Actualizar(evento);
            }
        }
    }
}
