using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    internal class Dato
    {
        public string Nombre { get; set; }
        public int Duracion { get; set; }

        public Dato(string nombre, int duracion)
        {
            this.Nombre = nombre;
            this.Duracion = duracion;
        }

    }
}
