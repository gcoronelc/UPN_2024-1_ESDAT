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
            } else {
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
            PostOrden(raiz);
        }

        private void InOrden(Nodo nodo)
        {
            if(nodo == null)
            {
                return;
            }
            InOrden(nodo.izquierda);
            Console.Write(nodo.toCadena() + " ");
            InOrden(nodo.derecha);
        }

        private void PreOrden(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            Console.Write(nodo.toCadena() + " ");
            PreOrden(nodo.izquierda);
            PreOrden(nodo.derecha);
        }

        private void PostOrden(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            PostOrden(nodo.izquierda);
            PostOrden(nodo.derecha);
            Console.Write(nodo.toCadena() + " ");
        }

        public void mostrarAlumnos(int nota)
        {
            if(raiz == null)
            {
                Console.WriteLine("No existe nodos.");
                return;
            }
            mostrarAlumnosRecursivo(raiz,nota);
        }

        public void mostrarAlumnosRecursivo(Nodo nodo, int nota)
        {
            if (raiz == null)
            {
                return;
            }
            if (nodo.nota == nota)
            {
                Console.WriteLine(nodo.toCadena());
                return;
            }
            if(nota < nodo.nota)
            {
                mostrarAlumnosRecursivo(nodo.izquierda,nota);
            } 
            else
            {
                mostrarAlumnosRecursivo(nodo.derecha, nota);
            }
        }
    }
}
