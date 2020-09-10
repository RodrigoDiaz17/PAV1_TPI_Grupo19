using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMet.Clases.Sistema
{
    public class Grapper
    {
        private bool Void = true;
        private object ObjectToGrap;

        public Grapper(){}
        public object Object { get => ObjectToGrap; set {  ObjectToGrap = value; Void = false;} }
        public bool IsVoid { get => Void; }
    
    }
}
