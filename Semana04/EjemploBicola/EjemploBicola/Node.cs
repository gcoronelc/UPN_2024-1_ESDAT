﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBicola
{
    internal class Node
    {
        public int value { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }

        public Node(int value)
        {
            this.value = value;
            next = null;
            prev = null;
        }
    }
}
