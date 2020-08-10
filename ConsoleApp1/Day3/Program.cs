using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Print Middle element
namespace Day3
{
    class List
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
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
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
        int countNodes(Node ptr)
        {
            int count = 1;
            Node temp = ptr;
            while(temp.next != ptr)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public int PrintMiddle()
        {
            Node fast_ptr = head, slow_ptr = head;
            while(fast_ptr != null && slow_ptr != null && fast_ptr.next != null)
            {
                fast_ptr = fast_ptr.next.next;
                slow_ptr = slow_ptr.next;
                if (fast_ptr == slow_ptr)
                {
                    return countNodes(slow_ptr);
                }
            }
            Console.WriteLine("Loop not found");
           // Console.Write("Middle element is "+ slow_ptr.data);
            return slow_ptr.data;
        }
        static void Main(string[] args)
        {
            List l1 = new List();
            l1.Push(1);
            l1.Push(2);
            l1.Push(3);
            l1.Push(4);
            l1.Push(5);
            l1.head.next.next.next.next.next = l1.head.next;
           // l1.PrintList();
            Console.WriteLine();
            Console.WriteLine(l1.PrintMiddle());
            Console.ReadKey();
        }
    }
}
