using System;

namespace pairwiseSwapElements
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
                data = d;
                next = null;
            }
        }
        public void Push(int newData)
        {
            Node new_node = new Node(newData);
            new_node.next = head;
            head = new_node;
        }
        public void Print()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void pairwiseSwap()
        {
            Node temp = head;
            while(temp != null && temp.next != null)
            {
                int data = temp.data;
                temp.data = temp.next.data;
                temp.next.data = data;
                temp = temp.next.next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Push(1);
            l.Push(2);
            l.Push(3);
            l.Push(4);
            l.Print();
            Console.WriteLine();
            l.pairwiseSwap();
            l.Print();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
