using BibliotecaMET.Clases.Temas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMET.Clases.Interfaces.Adaptadores
{
    public interface IPublicador
    {
        
        void RegristrarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void Notificar(object publicador);
        
    }
}
