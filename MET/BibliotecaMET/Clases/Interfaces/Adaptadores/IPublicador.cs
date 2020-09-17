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
        void QuitarObservador(System.Windows.Forms.Form form);
        void Notificar(object publicador);
        
    }
}
