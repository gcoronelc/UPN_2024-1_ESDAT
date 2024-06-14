using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaPrioridad
{
    internal class PriorityQueue
    {
        private Node head;
        private Node tail;

        public PriorityQueue()
        {
            this.head = null;
            this.tail = null;
        }

        public void Enqueue(int value, int priority)
        {
            Node newNode = new Node(value,priority);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            if (priority < head.Priority)
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
                return;
            }
            
            Node current = head;
            while (current.Next != null && current.Next.Priority <= priority)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            newNode.Prev = current;
            if (newNode.Next != null)
                newNode.Next.Prev = newNode;
            else
                tail = newNode;
            current.Next = newNode;
        }

        public int Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("La cola está vacía.");

            int value = head.Value;
            head = head.Next;
            if (head != null)
                head.Prev = null;
            else
                tail = null;

            return value;
        }

        public void cambiarPrioridad(int value, int newPriority)
        {
            // Falta cambiar de posicion
           Node actul = head; 
            while(actul != null)
            {
                if (actul.Value == value){
                    actul.Priority = newPriority;
                }
                actul = actul.Next;
            }


        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.ToString() + " -> ");
                current = current.Next;
            }
            Console.WriteLine(" NULL");
        }
    }
}
