using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
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
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        void PrintList(Node temp)
        {
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        Node Reverse(Node current, Node prev)
        {
            if(current.next == null)
            {
                head = current;
                current.next = prev;
                return head;
            }
            Node Next = current.next;
            current.next = prev;
            Reverse(Next, current);
            return head;
        }
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.Push(1);
            l1.Push(2);
            l1.Push(3);
            l1.Push(4);
            l1.Push(5);
            l1.PrintList(l1.head);
            Node temp = l1.Reverse(l1.head, null);
            Console.WriteLine();
            l1.PrintList(temp);
            Console.ReadKey();
        }
    }
}