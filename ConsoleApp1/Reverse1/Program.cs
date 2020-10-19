using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse1
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
        public void AddLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if(head == null)
            {
                head = new_node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
        }
        public void PrintList()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
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
            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            l1.PrintList();
            Console.WriteLine();
            l1.ReverseList();
            l1.PrintList();
            Console.ReadKey();
        }
    }
}
