using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Iparraguirre
    {
        // Método para contar los elementos de una lista
        public int ContarElementos(Lista lista)
        {
            int contador = 0;
            Nodo actual = lista.Cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        // Método para verificar si dos listas son iguales
        public bool SonIguales(Lista lista1, Lista lista2)
        {
            Nodo actual1 = lista1.Cabeza;
            Nodo actual2 = lista2.Cabeza;

            // Recorrer ambas listas mientras ambos nodos no sean nulos
            while (actual1 != null && actual2 != null)
            {
                // Si los datos de los nodos actuales son diferentes, las listas no son iguales
                if (actual1.Dato != actual2.Dato)
                {
                    return false;
                }
                // Avanzar al siguiente nodo en ambas listas
                actual1 = actual1.Siguiente;
                actual2 = actual2.Siguiente;
            }

            // Si ambas listas terminan al mismo tiempo (es decir, ambos nodos son nulos), son iguales
            return actual1 == null && actual2 == null;
        }


        // Método para concatenar dos listas
        public Lista ConcatenarListas(Lista lista1, Lista lista2)
        {
            Lista nuevaLista = new Lista();

            // Copiar nodos de lista1 a nuevaLista
            Nodo actual = lista1.Cabeza;
            while (actual != null)
            {
                nuevaLista.AgregarNodo(actual.Dato);
                actual = actual.Siguiente;
            }

            // Copiar nodos de lista2 a nuevaLista
            actual = lista2.Cabeza;
            while (actual != null)
            {
                nuevaLista.AgregarNodo(actual.Dato);
                actual = actual.Siguiente;
            }

            return nuevaLista;
        }

        // Método para invertir una lista
        public Lista InvertirLista(Lista lista)
        {
            Lista listaInvertida = new Lista();
            Nodo actual = lista.Cabeza;
            while (actual != null)
            {
                Nodo nuevoNodo = new Nodo(actual.Dato)
                {
                    Siguiente = listaInvertida.Cabeza
                };
                listaInvertida.Cabeza = nuevoNodo;
                actual = actual.Siguiente;
            }
            return listaInvertida;
        }

        // Método para ordenar una lista
        public Lista OrdenarLista(Lista lista, int tipo)
        {
            Lista listaOrdenada = new Lista();
            Nodo actual = lista.Cabeza;
            while (actual != null)
            {
                listaOrdenada.AgregarNodo(actual.Dato);
                actual = actual.Siguiente;
            }

            if (tipo == 1)
            {
                
                listaOrdenada.Cabeza = MergeSort(listaOrdenada.Cabeza, true);
            }
            else if (tipo == 2)
            {
                listaOrdenada.Cabeza = MergeSort(listaOrdenada.Cabeza, false);
            }

            return listaOrdenada;
        }

        // Método auxiliar para ordenación MergeSort
        private Nodo MergeSort(Nodo cabeza, bool ascendente)
        {
            if (cabeza == null || cabeza.Siguiente == null)
            {
                return cabeza;
            }

            Nodo medio = ObtenerMedio(cabeza);
            Nodo siguienteMedio = medio.Siguiente;
            medio.Siguiente = null;

            Nodo izquierda = MergeSort(cabeza, ascendente);
            Nodo derecha = MergeSort(siguienteMedio, ascendente);

            return Merge(izquierda, derecha, ascendente);
        }

        // Método para obtener el nodo medio de la lista
        private Nodo ObtenerMedio(Nodo cabeza)
        {
            if (cabeza == null)
            {
                return cabeza;
            }

            Nodo lento = cabeza, rapido = cabeza.Siguiente;

            while (rapido != null && rapido.Siguiente != null)
            {
                lento = lento.Siguiente;
                rapido = rapido.Siguiente.Siguiente;
            }
            return lento;
        }

        // Método para fusionar dos sublistas
        private Nodo Merge(Nodo izquierda, Nodo derecha, bool ascendente)
        {
            if (izquierda == null)
            {
                return derecha;
            }
            if (derecha == null)
            {
                return izquierda;
            }

            Nodo resultado;
            if ((ascendente && izquierda.Dato <= derecha.Dato) || (!ascendente && izquierda.Dato >= derecha.Dato))
            {
                resultado = izquierda;
                resultado.Siguiente = Merge(izquierda.Siguiente, derecha, ascendente);
            }
            else
            {
                resultado = derecha;
                resultado.Siguiente = Merge(izquierda, derecha.Siguiente, ascendente);
            }
            return resultado;
        }

        // Método para restar dos listas
        public Lista RestarLista(Lista lista1, Lista lista2)
        {
            Lista resultado = new Lista();
            Nodo actual1 = lista1.Cabeza;
            while (actual1 != null)
            {
                Nodo actual2 = lista2.Cabeza;
                bool encontrado = false;
                while (actual2 != null)
                {
                    if (actual1.Dato == actual2.Dato)
                    {
                        encontrado = true;
                        break;
                    }
                    actual2 = actual2.Siguiente;
                }
                if (!encontrado)
                {
                    resultado.AgregarNodo(actual1.Dato);
                }
                actual1 = actual1.Siguiente;
            }
            return resultado;
        }

        // Método para calcular el promedio del mayor y menor elemento de una lista
        public double PromedioElemento(Lista lista)
        {
            if (lista.Cabeza == null)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            Nodo actual = lista.Cabeza;
            while (actual != null)
            {
                if (actual.Dato > max)
                {
                    max = actual.Dato;
                }
                if (actual.Dato < min)
                {
                    min = actual.Dato;
                }
                actual = actual.Siguiente;
            }
            return (max + min) / 2.0;
        }
    }
}
