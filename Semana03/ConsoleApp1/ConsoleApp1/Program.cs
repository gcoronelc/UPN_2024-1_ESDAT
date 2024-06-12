using System;
using System.Collections.Generic;
namespace ArbolBinario
{
    // Clase Nodo representa un nodo en el árbol binario
    public class Nodo
    {
        public int Valor { get; set; } // Valor del nodo
        public Nodo Izquierda { get; set; } // Hijo izquierdo
        public Nodo Derecha { get; set; } // Hijo derecho
                                          // Constructor para inicializar el nodo con un valor
        public Nodo(int valor)
        {
            Valor = valor; // Asigna el valor al nodo
            Izquierda = null; // Inicializa el hijo izquierdo como null
            Derecha = null; // Inicializa el hijo derecho como null
        }
    }
    // Clase ArbolBinario representa un árbol binario
    public class ArbolBinario
    {
        public Nodo Raiz { get; set; } // Nodo raíz del árbol
                                       // Constructor que inicializa un árbol binario con una raíz nula
        public ArbolBinario()
        {
            Raiz = null; // Inicializa la raíz como null
        }
        // Método para agregar nodos al árbol binario (no balanceado)
        public void Agregar(int valor)
        {
            Raiz = AgregarRecursivo(Raiz, valor); // Llama al método recursivo para agregar el nodo
        }
        // Método recursivo para agregar un nodo al árbol
        private Nodo AgregarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) // Si el nodo actual es null
            {
                return new Nodo(valor); // Crea un nuevo nodo con el valor dado
            }
            
        if (valor < nodo.Valor) // Si el valor es menor que el valor del nodo actual
            {
                nodo.Izquierda = AgregarRecursivo(nodo.Izquierda, valor); // Agrega el nodo al subárbol izquierdo
            }
            else if (valor > nodo.Valor) // Si el valor es mayor que el valor del nodo actual
            {
                nodo.Derecha = AgregarRecursivo(nodo.Derecha, valor); // Agrega el nodo al subárbol derecho
            }
            return nodo; // Retorna el nodo actualizado
        }
        // Método para recorrer el árbol en preorden
        public void RecorrerPreorden(Nodo nodo)
        {
            if (nodo != null) // Si el nodo actual no es null
            {
                Console.Write(nodo.Valor + " "); // Muestra el valor del nodo
                RecorrerPreorden(nodo.Izquierda); // Recorre el subárbol izquierdo en preorden
                RecorrerPreorden(nodo.Derecha); // Recorre el subárbol derecho en preorden
            }
        }
        // Método para recorrer el árbol en inorden
        public void RecorrerInorden(Nodo nodo)
        {
            if (nodo != null) // Si el nodo actual no es null
            {
                RecorrerInorden(nodo.Izquierda); // Recorre el subárbol izquierdo en inorden
                Console.Write(nodo.Valor + " "); // Muestra el valor del nodo
                RecorrerInorden(nodo.Derecha); // Recorre el subárbol derecho en inorden
            }
        }
        // Método para recorrer el árbol en postorden
        public void RecorrerPostorden(Nodo nodo)
        {
            if (nodo != null) // Si el nodo actual no es null
            {
                RecorrerPostorden(nodo.Izquierda); // Recorre el subárbol izquierdo en postorden
                RecorrerPostorden(nodo.Derecha); // Recorre el subárbol derecho en postorden
                Console.Write(nodo.Valor + " "); // Muestra el valor del nodo
                
            }
        }
        // Método para contar el número de nodos del árbol
        public int ContarNodos(Nodo nodo)
        {
            if (nodo == null) // Si el nodo actual es null
            {
                return 0; // Retorna 0 porque no hay nodo
            }
            return 1 + ContarNodos(nodo.Izquierda) + ContarNodos(nodo.Derecha); // Cuenta el nodo actual y los nodos de los subárboles
        }
        // Método para contar el número de hojas del árbol
        public int ContarHojas(Nodo nodo)
        {
            if (nodo == null) // Si el nodo actual es null
            {
                return 0; // Retorna 0 porque no hay nodo
            }
            if (nodo.Izquierda == null && nodo.Derecha == null) // Si el nodo es una hoja
            {
                return 1; // Retorna 1 porque es una hoja
            }
            return ContarHojas(nodo.Izquierda) + ContarHojas(nodo.Derecha); // Cuenta las hojas de los subárboles
        }
        // Método para devolver el mayor valor del árbol
        public int MayorValor(Nodo nodo)
        {
            if (nodo == null) // Si el nodo actual es null
            {
                throw new InvalidOperationException("El árbol está vacío."); // Lanza una excepción si el árbol está vacío
            }
            while (nodo.Derecha != null) // Recorre hacia la derecha para encontrar el mayor valor
            {
                nodo = nodo.Derecha; // Avanza al siguiente nodo derecho
            }
            return nodo.Valor; // Retorna el mayor valor
        }
// Método para eliminar un nodo del árbol

public Nodo EliminarNodo(Nodo nodo, int valor)
        {
            if (nodo == null) // Si el nodo actual es null
            {
                return nodo; // Retorna null
            }
            if (valor < nodo.Valor) // Si el valor es menor que el valor del nodo actual
            {
                nodo.Izquierda = EliminarNodo(nodo.Izquierda, valor); // Elimina el nodo del subárbol izquierdo
            }
            else if (valor > nodo.Valor) // Si el valor es mayor que el valor del nodo actual
            {
                nodo.Derecha = EliminarNodo(nodo.Derecha, valor); // Elimina el nodo del subárbol derecho
            }
            else // Si se encuentra el nodo a eliminar
            {
                if (nodo.Izquierda == null) // Si el nodo no tiene hijo izquierdo
                {
                    return nodo.Derecha; // Retorna el hijo derecho
                }
                else if (nodo.Derecha == null) // Si el nodo no tiene hijo derecho
                {
                    return nodo.Izquierda; // Retorna el hijo izquierdo
                }
                nodo.Valor = ValorMinimo(nodo.Derecha); // Reemplaza el valor del nodo con el valor mínimo del subárbol derecho
                nodo.Derecha = EliminarNodo(nodo.Derecha, nodo.Valor); // Elimina el nodo que tiene el valor mínimo del subárbol derecho
            }
            return nodo; // Retorna el nodo actualizado
        }
        // Método para encontrar el valor mínimo de un subárbol
        private int ValorMinimo(Nodo nodo)
        {
            int min = nodo.Valor; // Inicializa el mínimo con el valor del nodo actual
            while (nodo.Izquierda != null) // Recorre hacia la izquierda para encontrar el menor valor
            {
                min = nodo.Izquierda.Valor; // Actualiza el mínimo con el valor del hijo izquierdo
                nodo = nodo.Izquierda; // Avanza al siguiente nodo izquierdo
                
            }
            return min; // Retorna el valor mínimo
        }
        // Método para dibujar el árbol binario
        public void DibujarArbol(Nodo nodo, string sangria = "", bool ultimo = true)
        {
            if (nodo != null)
            {
                Console.Write(sangria);
                if (ultimo)
                {
                    Console.Write("└─");
                    sangria += " ";
                }
                else
                {
                    Console.Write("├─");
                    sangria += "| ";
                }
                Console.WriteLine(nodo.Valor);
                DibujarArbol(nodo.Izquierda, sangria, false);
                DibujarArbol(nodo.Derecha, sangria, true);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario(); // Crea una nueva instancia de ArbolBinario
                                                     // Agregar nodos según el árbol dado
            arbol.Agregar(8); // Raíz
            arbol.Agregar(3); // Hijo izquierdo
            arbol.Agregar(1); // Hijo izquierdo de 3
            arbol.Agregar(6); // Hijo derecho de 3
            arbol.Agregar(4); // Hijo izquierdo de 6
            arbol.Agregar(7); // Hijo derecho de 6
            arbol.Agregar(10); // Hijo derecho
            arbol.Agregar(14); // Hijo derecho de 10
            arbol.Agregar(13); // Hijo izquierdo de 14
            
        
        // Menú de opciones
int opcion;
            do
            {
                Console.WriteLine("\nMENU ARBOL BINARIO");
                Console.WriteLine("1. Mostrar recorridos");
                Console.WriteLine("2. Número de nodos del árbol");
                Console.WriteLine("3. Número de hojas del árbol");
                Console.WriteLine("4. Devolver el mayor valor del árbol");
                Console.WriteLine("5. Eliminar un nodo del árbol");
                Console.WriteLine("6. Dibujar árbol");
                Console.WriteLine("7. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nRecorrido en Preorden:");
                        arbol.RecorrerPreorden(arbol.Raiz);
                        Console.WriteLine("\nRecorrido en Inorden:");
                        arbol.RecorrerInorden(arbol.Raiz);
                        Console.WriteLine("\nRecorrido en Postorden:");
                        arbol.RecorrerPostorden(arbol.Raiz);
                        break;
                    case 2:
                        Console.WriteLine("Número de nodos del árbol: " + arbol.ContarNodos(arbol.Raiz));
                        break;
                    case 3:
                        Console.WriteLine("Número de hojas del árbol: " + arbol.ContarHojas(arbol.Raiz));
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Mayor valor del árbol: " + arbol.MayorValor(arbol.Raiz));
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.Write("Ingresa el valor del nodo a eliminar: ");
                        int valorEliminar = int.Parse(Console.ReadLine());
                        arbol.EliminarNodo(arbol.Raiz, valorEliminar);
                        
                
                Console.WriteLine("Nodo eliminado.");
                        break;
                    case 6:
                        Console.WriteLine("Dibujo del árbol binario:");
                        arbol.DibujarArbol(arbol.Raiz);
                        break;
                    case 7:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 7);
        }
    }
}