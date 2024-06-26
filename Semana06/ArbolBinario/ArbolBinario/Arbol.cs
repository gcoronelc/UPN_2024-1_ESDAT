using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Arbol
    {
        public Nodo raiz {  get; set; }

        public Arbol() {
            raiz = null;
        }

        public Arbol(string estudiante, int nota)
        {
            raiz = null;
            this.agregarNodo(estudiante, nota); 
        }

        public void agregarNodo(string estudiante, int nota)
        {
            if(raiz == null)
            {
                raiz = new Nodo(estudiante, nota);
                return;
            }
            Nodo nuevoNodo = new Nodo(estudiante, nota);
            agregarNodoArbol(raiz, nuevoNodo);
        }

        private void agregarNodoArbol(Nodo nodo, Nodo nuevoNodo)
        {
            if(nuevoNodo.nota < nodo.nota)
            {
                if(nodo.izquierda == null)
                {
                    nodo.izquierda = nuevoNodo;
                } else
                {
                    agregarNodoArbol(nodo.izquierda, nuevoNodo);
                }
            } else
            {
                if (nodo.derecha == null)
                {
                    nodo.derecha = nuevoNodo;
                }
                else
                {
                    agregarNodoArbol(nodo.derecha, nuevoNodo);
                }
            }
        }

        public void imprimir()
        {

        }

        public void mostrarAlumnos(int nota)
        {

        }
    }
}
