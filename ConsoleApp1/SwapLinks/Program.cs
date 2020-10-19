using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairwiseSwap
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
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void SwapNodes(int data1, int data2)
        {
            Node temp = head;
            Node node1 = null, node2 = null;
            while (temp.next != null)
            {
                if(temp.data == data1)
                {
                    node1 = temp;
                }
                else if (temp.data == data2)
                {
                    node2 = temp;
                }
                temp = temp.next;
            }
            if(node1 != null && node2 != null)
            {
                Node Next = node1.next;
                node1.next = node2.next;
                node2.next = Next;
                Next = node1.next.next;
                node1.next.next = node2.next.next;
                node2.next.next = Next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.Push(7);
            l1.Push(6);
            l1.Push(5);
            l1.Push(4);
            l1.Push(3);
            l1.Push(2);
            l1.Push(1);
            l1.Print();
            Console.WriteLine("Swapped");
            l1.SwapNodes(6,3);
            l1.Print();
            Console.ReadKey();
        }
    }
}
