using System;

namespace JosephusPosition
{
    class CLL
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
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            Node temp = head;
            new_node.next = head;

            if (head != null)
            {
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            else
                new_node.next = new_node;

            head = new_node;
        }
        public void Print()
        {
            Node temp = head;
            if(head != null)
            {
                do
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                } while (temp != head);
            }
        }
        public void GetJosephusPosition(int n, int m)
        {
            Node ptr1 = head, prev = head;
            while(ptr1.next != prev)
            {
                int count = 1;
                while(count != m)
                {
                    prev = ptr1;
                    ptr1 = ptr1.next;
                    count++;
                }
                prev.next = ptr1.next;
                ptr1 = prev.next;
            }
            Console.WriteLine();
            Console.WriteLine(ptr1.data);
        }
        static void Main(string[] args)
        {
            CLL l = new CLL();
            l.Push(1);
            l.Push(2);
            l.Push(3);
            l.Push(4);
            l.Push(5);
            l.Push(6);
            l.Push(7);
            l.Push(8);
            l.Push(9);
            l.Push(10);
            l.Push(11);
            l.Push(12);
            l.Push(13);
            l.Push(14);
            l.Print();
            l.GetJosephusPosition(14, 2);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
