using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatoria
{
    internal class Nodo
    {
        public int dato { get; set; }
        public Nodo siguiente { get; set; }
        public Nodo (int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
