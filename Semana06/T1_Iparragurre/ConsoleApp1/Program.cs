using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elementos de la lista 01: ");
            Lista lista1 = new Lista(5); // Crear una lista con 10 elementos aleatorios
            lista1.ImprimirLista();
            Console.WriteLine();

            Console.WriteLine("Elementos de la lista 02: ");
            Lista lista2 = new Lista(5); // Crear una lista vacía
            lista2.ImprimirLista();
            Console.WriteLine();

            Iparraguirre operaciones = new Iparraguirre();

            // Contar elementos de lista1
            Console.WriteLine("Contador de elementos en lista1: " + operaciones.ContarElementos(lista1));
            Console.WriteLine("Contador de elementos en lista2: " + operaciones.ContarElementos(lista2));

            Console.WriteLine();

            // Verificar si lista1 y lista2 son iguales
            string rpta = operaciones.SonIguales(lista1, lista2) == true ? "Las dos listas son iguales" : "Las dos listas NO son iguales";
             
            Console.WriteLine("¿Son iguales lista1 y lista2 en tamaño y contenido? " + rpta);

            Console.WriteLine();

            // Concatenar lista1 y lista2
            Lista listaConcatenada = operaciones.ConcatenarListas(lista1, lista2);
            Console.WriteLine("Lista concatenada: ");
            listaConcatenada.ImprimirLista();

            Console.WriteLine();

            // Invertir lista1
            Lista listaInvertida = operaciones.InvertirLista(lista1);
            Console.WriteLine("Lista 1 invertida: ");
            listaInvertida.ImprimirLista();

            Console.WriteLine();

            // Ordenar lista1 en forma ascendente
            Lista listaOrdenadaAsc = operaciones.OrdenarLista(lista1, 1);
            Console.WriteLine("Lista 1 ordenada ascendente: ");
            listaOrdenadaAsc.ImprimirLista();

            Console.WriteLine();

            // Ordenar lista1 en forma descendente
            Lista listaOrdenadaDesc = operaciones.OrdenarLista(lista1, 2);
            Console.WriteLine("Lista 1 ordenada descendente: ");
            listaOrdenadaDesc.ImprimirLista();

            Console.WriteLine();

            // Restar lista2 de lista1
            Lista listaRestada = operaciones.RestarLista(lista1, lista2);
            Console.WriteLine("Lista restada (lista1 - lista2): ");
            listaRestada.ImprimirLista();

            Console.WriteLine();

            // Calcular promedio del mayor y menor elemento de lista1
            double promedio = operaciones.PromedioElemento(lista1);
            Console.WriteLine("Promedio entre el mayor y menor elemento de lista1: " + promedio);

            Console.ReadKey();
        }
    }
}
