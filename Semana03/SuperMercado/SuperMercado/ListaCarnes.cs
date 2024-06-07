using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    internal class ListaCarnes
    {
        private Nodo cabeza;

        public ListaCarnes()
        {
            cabeza = null;
        }

        public void AgregarNodo(string Nombre, int Duracion)
        {
            Nodo newNodo = new Nodo(Nombre, Duracion);
            newNodo.Siguiente = cabeza;
            cabeza=newNodo;
            OrdenarLista();
        }

        private void OrdenarLista()
        {
            if (cabeza == null || cabeza.Siguiente == null)
            {
                return;
            }
            int n = contarNodos() - 1;
            while (n > 0)
            {
                Nodo aux = cabeza;
                bool hayCambios = false;
                for (int j = 1; j <= n; j++)
                {
                    if (aux.dato.Duracion > aux.Siguiente.dato.Duracion)
                    {
                        Dato temp = aux.dato;
                        aux.dato = aux.Siguiente.dato;
                        aux.Siguiente.dato = temp;
                        hayCambios = true;
                    }
                    aux = aux.Siguiente;
                }
                if (!hayCambios)
                {
                    break;
                }
                n--;
            }
        }

        private int contarNodos()
        {
            int conta = 0;
            Nodo aux = cabeza;
            while (aux != null)
            {
                conta++;
                aux = aux.Siguiente;
            }
            return conta;
        }

        public void ImprimirLista()
        {
            Nodo auxiliar = cabeza;
            while (auxiliar != null)
            {
                Console.WriteLine(auxiliar.dato.Nombre + "  " + auxiliar.dato.Duracion);
                auxiliar = auxiliar.Siguiente;
            }
            Console.WriteLine();
        }

        public Dato ExtraerCarne()
        {
            if (cabeza == null)
            {
                throw new InvalidOperationException("Lista vacia");
                 }
            Nodo auxiliar = cabeza;
            cabeza = auxiliar.Siguiente;
            return auxiliar.dato;
        }
    }
}
