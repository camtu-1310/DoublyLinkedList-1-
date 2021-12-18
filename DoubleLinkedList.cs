using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnKTHP
{
    class DoubleLinkedList
    {
        public Node header;
        public DoubleLinkedList()
        {
            header = new Node(new Book("Header", "Header", "Header", 0.0f, "Header", 0.0f));
        }
        private Node Find(string id)
        {
            Node current = new Node();
            current = header;
            while (current.element.getId() != id)
            {
                current = current.flink;
            }
            return current;
        }
        
        public void InsertAfter(Book newbook, string id)
        {
            Node current = new Node();
            Node newnode = new Node(newbook);
            current = Find(id);
            newnode.flink = current.flink;
            newnode.blink = current;
            current.flink = newnode;
        }
        public void InsertBefore(Book newbook, string id)
        {
            Node current = new Node();
            Node newnode = new Node(newbook);
            current = Find(id);
            newnode.blink = current.blink;
            newnode.flink = current;
            current.blink.flink = newnode;
            current.blink = newnode;
        }
        //public void InsertFirst(Book newbook, )
        public void InsertFirst(Book newbook)
        {
            Node current = new Node();
            Node element = new Node(newbook);
            current = Find("Header");
            element.flink = current.flink;
            element.blink = current;
            current.flink = element;

        }
        public void InsertLast(Book newbook)
        {
            Node current = new Node();

            Node newnode = new Node(newbook);
            if (current != null)
            {
                current = header;
                while (current.flink != null)
                {
                    current = current.flink;
                }
                current.flink = newnode;
                current.flink.blink = current;


            }
        }
        public void DeleteFirstNode()
        {
            Node current = new Node();
            current = Find("Header");
            // xoá node đầu tiên
            current = current.flink;
            current.element = null;
        }

        public void Remove(string id)
        {
            // tìm kiếm id cần xoá
            Node current = Find(id);
            // nếu link có nhiều hơn 1 node
            if (current.flink != null)
            {
                // xoá node
                current.blink.flink = current.flink;
                current.flink.blink = current.blink;
                current.flink = null;
                current.blink = null;
            }
        }
        public void DeleteLastNode()
        {
            Node current = new Node();
            // tìm kiếm gtri node cuối cùng
            current = FindLast();
            //xoá node cuối cùng
            current.blink.flink = null;
        }
        public void Reverse()
        {
            
            Node temp = null; 
            Node current = new Node();
            current = Find("Header");

            while (current != null)
            {
                temp = current.blink;
                current.blink = current.flink;
                current.flink = temp;
                current = current.blink;
            }
        }
        
        public void Print()
        {
            Node current = new Node();
            current = FindLast();
            while (!(current.blink == null))
            {
                Console.WriteLine(current.element);
                current = current.blink;
            }
        }
        public Node FindLast()
        {
            Node current = new Node();
            current = header;
            while (!(current.flink == null))
                current = current.flink;

            return current;
        }
        public int Count()
        {
            int count = 0;
            Node current = new Node();
            current = Find("Header");
            current = current.flink;
            while (current != null)
            {
                count++;
                current = current.flink;
            }
            return count;
        }
        public void DeleteAll()
        {
            Node current = new Node();
            current = Find("Header");
            current = current.flink;
            while (current != null)
            {
                current.element = null;
                current = current.flink;
            }
        }
        public void DisplayList()
        {
            Node p;
            if (header != null)
            {

                p = header;
                p = p.flink;
                while (p != null)
                {
                    Console.WriteLine(p.element + " ");
                    p = p.flink;
                }
            }
            Console.WriteLine();

        }
    }
}
