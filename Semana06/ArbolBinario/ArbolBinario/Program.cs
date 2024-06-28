using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Arbol raiz = new Arbol("Pedro",8);
            raiz.agregarNodo("Juan", 3);
            raiz.agregarNodo("Manuel", 10);
            raiz.agregarNodo("Karla", 1);
            raiz.agregarNodo("Susana", 6);
            raiz.agregarNodo("Daniel", 14);
            raiz.agregarNodo("Jose", 4);
            raiz.agregarNodo("Mariela", 13);
            raiz.agregarNodo("Daniela", 7);
            raiz.agregarNodo("Alejandra", 14);

            Console.WriteLine("Por ahora todo bien!!!");
            raiz.imprimir();
            Console.WriteLine("\n--------------");
            raiz.mostrarAlumnos(14);
            Console.ReadKey();

        }
    }
}
