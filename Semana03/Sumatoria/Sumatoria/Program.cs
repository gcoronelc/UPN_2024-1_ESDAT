using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(10);
            lista.ImprimirLista();
            Console.WriteLine("SUMATORIA: " + lista.Sumatoria());
            Console.WriteLine("Suma Pares: "+lista.SumaPares());
            Console.WriteLine("Suma Impares: " + lista.SumaImpares());
            lista.OrdenarAscendente();
            lista.ImprimirLista();
            Console.ReadKey();
        }
    }
}
