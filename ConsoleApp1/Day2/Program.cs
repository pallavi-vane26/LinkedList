using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class LinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                this.data = d;
                this.next = null;
            }
        }
        public void Push(int d)
        {
            Node new_node = new Node(d);
            new_node.next = head;
            head = new_node;
        }
        public void PrintList()
        {
            while(head != null) {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
        public void PrintMiddle()
        {
            Node fast_ptr = head;
            Node slow_ptr = head;
            if(head != null)
            {
                while (fast_ptr != null && fast_ptr.next != null && slow_ptr != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("Middle ele is " + slow_ptr.data);
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            list.Push(6);
           // list.PrintList();
            list.PrintMiddle();
            Console.ReadKey();
        }
    }
}
