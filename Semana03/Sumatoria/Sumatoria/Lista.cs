using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatoria
{
    internal class Lista
    {
        private Nodo cabeza;
        private Random random = new Random();

        public Lista(int n)
        {
            cabeza = null;
            for (int i = 0; i < n; i++)
            {
                AgregarNodo(GeneraValor());
            }
        }

        private int GeneraValor()
        {
            return random.Next(1, 100);
        }

        public void AgregarNodo(int valor)
        {
            Nodo newNodo = new Nodo(valor);
            newNodo.siguiente = cabeza;
            cabeza = newNodo;
        }

        public void ImprimirLista()
        {
            Nodo auxiliar = cabeza;
            while (auxiliar != null)
            {
                Console.Write(auxiliar.dato+"  ");
                auxiliar = auxiliar.siguiente;
            }
            Console.WriteLine();
        }

        public int Sumatoria()
        {
            Nodo auxiliar = cabeza;
            int Suma = 0;
            while (auxiliar != null)
            {
                Suma += auxiliar.dato;
                auxiliar=auxiliar.siguiente;
            }
            return Suma;
        }
        public int SumaPares()
        {
            Nodo auxiliar = cabeza;
            int Suma = 0;
            while (auxiliar != null)
            {
                if(auxiliar.dato %2 == 0)
                {
                    Suma += auxiliar.dato;
                }
                auxiliar = auxiliar.siguiente;
            }
            return Suma;
        }
        public int SumaImpares()
        {
            Nodo auxiliar = cabeza;
            int Suma = 0;
            while (auxiliar != null)
            {
                if (auxiliar.dato % 2 == 1)
                {
                    Suma += auxiliar.dato;
                }
                auxiliar = auxiliar.siguiente;
            }
            return Suma;
        }


    }
}
