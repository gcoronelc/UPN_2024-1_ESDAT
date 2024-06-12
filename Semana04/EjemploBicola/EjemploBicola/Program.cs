using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleQueue bicola = new DoubleQueue();

            // Agregar elementos a la bicola
            //bicola.EnqueueFront(1);
            //bicola.EnqueueFront(2);
            //bicola.EnqueueFront(3);
            //bicola.EnqueueFront(4);
            //bicola.ImprimerCola();

            // Agregar elementos a la bicola
            //bicola.EnqueueRear(1);
            //bicola.EnqueueRear(2);
            // bicola.EnqueueRear(3);
            //bicola.EnqueueRear(4);
            //bicola.ImprimerCola2();

            // Agregar elementos a la bicola
            bicola.EnqueueFront(1);
            bicola.EnqueueFront(2);
            bicola.EnqueueFront(3);
            bicola.EnqueueFront(4);
            bicola.ImprimerCola2();

            // Eliminar elementos de la bicola
            //Console.WriteLine("Elemento eliminado de la cola frontal: " + bicola.DequeueFront());
            //Console.WriteLine("Elemento eliminado de la cola posterior: " + bicola.DequeueRear());

            // Verificar si la bicola está vacía
            /*
            if (bicola.front == null && bicola.rear == null)
            {
                Console.WriteLine("La bicola está vacía.");
            }
            else
            {
                Console.WriteLine("La bicola no está vacía.");
            }
            */
            Console.ReadKey();
        }
    }
}
