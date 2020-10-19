using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveLastToFront
{
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
            public void Move()
            {
                Node prevLast = null;
                Node temp = head;
                while (temp.next != null)
                {
                    prevLast = temp;
                    temp = temp.next;
                }
                prevLast.next = null;
                temp.next = head;
                head = temp;
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
                l1.Move();
                l1.Print();
                Console.ReadKey();
            }
        }
    }

}
