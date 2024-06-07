using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    internal class Nodo
    {
        public Dato dato {  get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string Nombre, int Duracion)
        {
            this.dato = new Dato(Nombre, Duracion);   
            this.Siguiente = null;
        }

    }
}
