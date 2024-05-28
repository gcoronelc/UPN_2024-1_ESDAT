using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pila pila = new Pila();

            // Apilar elementos
            pila.Apilar(1);
            pila.Apilar(2);
            pila.Apilar(3);

            // Obtener el elemento en la cima de la pila
            int cima = pila.Cima(); // Resultado: 3
            Console.WriteLine(cima);

            // Desapilar elementos
            int desapilado = pila.Desapilar(); // Resultado: 3
            Console.WriteLine(desapilado); // Salida: 3

            // Verificar si la pila está vacía
            bool estaVacia = pila.EstaVacia(); // Resultado: false
            Console.WriteLine(estaVacia);

            Console.ReadKey();

        }
    }
}
