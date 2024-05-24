using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            this.cabeza = null;
        }

        public void InsertarAlInicio(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            nuevoNodo.siguiente = cabeza;
            cabeza = nuevoNodo;
        }

        public void InsertarAlFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if(cabeza == null)
            {
                cabeza = nuevoNodo;
                return;
            }
            Nodo nodoAuxiliar = cabeza;
            while(nodoAuxiliar.siguiente != null)
            {
                nodoAuxiliar = nodoAuxiliar.siguiente;
            }
            nodoAuxiliar.siguiente = nuevoNodo;
        }

        public void eliminarNodo(int dato)
        {

            if (cabeza == null)
                return;

            if (cabeza.dato == dato)
            {
                cabeza = cabeza.siguiente;
                return;
            }

            Nodo anterior = null;
            Nodo actual = cabeza;

            while (actual != null && actual.dato != dato)
            {
                anterior = actual;
                actual = actual.siguiente;
            }

            if (actual == null)
                return;

            anterior.siguiente = actual.siguiente;
            actual.siguiente = null;

        }

        public void MostrarLista()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.dato + " -> ");
                actual = actual.siguiente;
            }
            Console.WriteLine("null");
        }
    }
}
