using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjemploBicola
{
    internal class DoubleQueue
    {
        private Node front;
        private Node rear; 

        public DoubleQueue()
        {
            front = null;
            rear = null;
        }

        public void EnqueueFront(int valor)
        {
            Node nuevoNode = new Node(valor);
            if (front == null)
            {
                front = nuevoNode;
                rear = nuevoNode;
            }
            else
            {
                nuevoNode.next = front;
                front.prev = nuevoNode;
                front = nuevoNode;
            }
        }

        public void EnqueueRear(int valor)
        {
            Node nuevoNode = new Node(valor);
            if (rear == null)
            {
                front = nuevoNode;
                rear = nuevoNode;
            }
            else
            {
                nuevoNode.prev = rear;
                rear.next = nuevoNode;
                rear = nuevoNode;
            }
        }

        public int DequeueFront()
        {
            if (front == null)
            {
                throw new InvalidOperationException("No hay elementos en la cola frontal");
            }
            int valor = front.value;
            if (front == rear)
            {
                front = null;
                rear = null;
            }
            else
            {
                front = front.next;
                front.prev = null;
            }
            return valor;
        }

        public int DequeueRear()
        {
            if (rear == null)
            {
                throw new InvalidOperationException("No hay elementos en la cola posterior");
            }
            int valor = rear.value;
            if (front == rear)
            {
                front = null;
                rear = null;
            }
            else
            {
                rear = rear.prev;
                rear.next = null;
            }
            return valor;
        }


        public void ImprimerCola()
        {
            if (this.front == null)  
            {
                Console.WriteLine("la cola esta vacia");
                return;
            }
            Node actual = this.front;
            while (actual != null)
            {
                Console.Write(actual.value.ToString()+" -> ");
                actual = actual.next;
            }
            Console.WriteLine("Null");
        }

        public void ImprimerCola2()
        {
            if (this.rear == null)
            {
                Console.WriteLine("la cola esta vacia");
                return;
            }
            Node actual = this.rear;
            while (actual != null)
            {
                Console.Write(actual.value.ToString() + " -> ");
                actual = actual.prev;
            }
            Console.WriteLine("Null");
        }
    }
}
