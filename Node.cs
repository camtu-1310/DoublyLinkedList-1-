using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnKTHP
{
    class Node
    {
        public Book element;
        public Node flink, blink;
        public Node()
        {
            element = null;
            flink = blink = null;
        }
        public Node(Book element)
        {
            this.element = element;
            flink = blink = null;
        }
    }
}
