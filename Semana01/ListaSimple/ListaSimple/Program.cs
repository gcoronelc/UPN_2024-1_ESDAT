using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaEnlazada lista = new ListaEnlazada();

            lista.InsertarAlInicio(3);
            lista.InsertarAlInicio(9);
            lista.InsertarAlInicio(5);
            lista.InsertarAlInicio(7);
            lista.InsertarAlInicio(9);

            lista.InsertarAlFinal(55);

            lista.eliminarNodo(3);

            Console.WriteLine("Lista enlazada:");
            lista.MostrarLista();

            Console.ReadKey();
        }
    }
}
