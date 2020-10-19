using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse2
{
    class LinkedList
    {
        Node head;
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                this.data = d;
                this.next = null;
            }
        }
        public void AddNode(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        void PrintList(Node temp)
        {
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Reverse()
        {
            Node current = head;
            Node prev = null, next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.AddNode(1);
            l1.AddNode(2);
            l1.AddNode(3);
            l1.AddNode(4);
            l1.AddNode(5);
            l1.PrintList(l1.head);
            l1.Reverse();
            Console.WriteLine();
            l1.PrintList(l1.head);
            Console.ReadKey();
;        }
    }
}
