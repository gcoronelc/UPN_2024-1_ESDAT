using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    internal class Pila
    {

        private Nodo tope;

        public Pila()
        {
            tope = null;
        }

        public void Apilar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        public int Desapilar()
        {
            if (tope == null)
                throw new InvalidOperationException("La pila está vacía.");

            int valor = tope.Valor;
            tope = tope.Siguiente;
            return valor;
        }

        public int Cima()
        {
            if (tope == null)
                throw new InvalidOperationException("La pila está vacía.");

            return tope.Valor;
        }

        public bool EstaVacia()
        {
            return tope == null;
        }
    }
}
