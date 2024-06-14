using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EjemploColaPrioridad
{
    internal class Node
    {


        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public int Priority { get; set; }


        public Node(int Value, int Priority) { 
            this.Value = Value;
            this.Priority = Priority;
            this.Next = null;
            this.Prev = null;
        }

        public string ToString()
        {
            string texto = "(" + this.Value + "," + this.Priority + ")";
            return texto;
        }

    }
}
