using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaPrioridad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PriorityQueue cola = new PriorityQueue();

            cola.Enqueue(800, 3);
            cola.Enqueue(600, 1);
            cola.Enqueue(500, 1);
            cola.Enqueue(700, 2);

            cola.Print();

            cola.cambiarPrioridad(500, 3);
            cola.Print();
            Console.ReadKey();
        }
    }
}
