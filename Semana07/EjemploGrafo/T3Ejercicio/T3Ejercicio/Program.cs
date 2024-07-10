using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo ListaRutasv = new Grafo();
            InicializarGrafo(ListaRutasv);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Mostrar rutas posibles a Villa María desde Buenos Aires");
                Console.WriteLine("2. Mostrar el camino más corto a Villa María desde Buenos Aires");
                Console.WriteLine("3. Cerrar programa");
                Console.Write("Seleccione una opción: ");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine();
                        ListaRutasv.MostrarRutas("A Buenos Aires", "C Rosario");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();    
                        ListaRutasv.MostrarCaminoMasCorto("A Buenos Aires", "C Rosario");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Programa finalizado.");
                        return;
                    default:
                        Console.WriteLine("Esa opción no existe.");
                        break;
                }
            }
        }
        static void InicializarGrafo(Grafo grafo)
        {
            Nodo buenosAires = grafo.AgregarNodo("A Buenos Aires");
            Nodo sanPedro = grafo.AgregarNodo("B San Pedro");
            Nodo rosario = grafo.AgregarNodo("C Rosario");
            Nodo villaMaria = grafo.AgregarNodo("D Villa María");
            Nodo sanLuis = grafo.AgregarNodo("E San Luis");
            Nodo bahiaBlanca = grafo.AgregarNodo("F Bahía Blanca");
            grafo.AgregarArista("A Buenos Aires", "B San Pedro");
            grafo.AgregarArista("B San Pedro", "C Rosario");
            grafo.AgregarArista("C Rosario", "D Villa María");
            grafo.AgregarArista("A Buenos Aires", "E San Luis");
            grafo.AgregarArista("E San Luis", "D Villa María");
            grafo.AgregarArista("A Buenos Aires", "F Bahía Blanca");
            grafo.AgregarArista("F Bahía Blanca", "E San Luis");
            grafo.AgregarArista("A Buenos Aires", "D Villa María");
        }
    }
}

