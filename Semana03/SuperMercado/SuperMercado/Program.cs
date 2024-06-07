using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaCarnes listaCarnes = new ListaCarnes();
            listaCarnes.AgregarNodo("Lomo Fino A1", 60);
            listaCarnes.AgregarNodo("Lomo Fino A2", 50);
            listaCarnes.AgregarNodo("Lomo Fino A3", 55);
            listaCarnes.ImprimirLista();
            Dato dato = listaCarnes.ExtraerCarne();
            Console.WriteLine("--------");
            listaCarnes.ImprimirLista();
            Console.ReadKey();
        }
    }
}
