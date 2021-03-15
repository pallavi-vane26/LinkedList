using System;

namespace SegregateEvenOdd
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
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
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
        public void SegregateEvenOdd()
        {
            Node end = head;
            Node prev = null;
            Node curr = head;
            while (end.next != null)
                end = end.next;

            Node new_end = end;
            while(curr.data % 2 != 0 && curr != end)
            {
                new_end.next = curr;
                curr = curr.next;
                new_end.next.next = null;
                new_end = new_end.next;
            }
            if(curr.data % 2 == 0)
            {
                head = curr;
                while(curr != end){
                    if (curr.data % 2 == 0)
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                    else
                    {
                        prev.next = curr.next;
                        new_end.next = curr;
                        curr.next = null;
                        new_end = curr;
                        curr = prev.next;
                    }
                }
                
            }
            if (new_end != end && end.data % 2 != 0)
            {
                prev.next = end.next;
                end.next = null;
                new_end.next = end;
            }
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Push(1);
            l.Push(2);
            l.Push(3);
            l.Push(4);
            l.Push(5);
            l.Push(6);
            l.Push(7);
            l.Push(8);
            l.Print();
            Console.WriteLine();
            l.SegregateEvenOdd();
            l.Print();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
