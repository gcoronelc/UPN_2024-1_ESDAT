using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lista
    {
        public Nodo Cabeza { get; set; }
        private static Random random = new Random();

        // Constructor que genera una lista con N elementos aleatorios
        public Lista(int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                AgregarNodo(random.Next(10, 30)); // Genera números entre 1 y 100
            }
        }

        // Constructor que genera una lista vacía
        public Lista()
        {
            Cabeza = null;
        }

        // Método para agregar un nodo al final de la lista
        public void AgregarNodo(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para imprimir la lista
        public void ImprimirLista()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine( "null" );
        }
    }
}
