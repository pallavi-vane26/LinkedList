using System;

namespace MergeSorted
{
    class LinkedList
    {
        Node head1, head2;
        class Node
        {
            public Node next;
            public int data;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        void PrintList(Node temp)
        {
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        Node SortedMerge(Node first, Node second)
        {
            Node result = null;
            if (first == null && second == null)
                return null;

            while(first != null && second != null)
            {
                if (first.data <= second.data)
                {
                    Node temp = first.next;
                    first.next = result;
                    result = first;
                    first = temp;
                }
                else
                {
                    Node temp = second.next;
                    second.next = result;
                    result = second;
                    second = temp;
                }
            }
            while(first != null)
            {
                Node temp1 = first.next;
                first.next = result;
                result = first;
                first = temp1;
            }
            while (second != null)
            {
                Node temp1 = first.next;
                second.next = result;
                result = second;
                first = temp1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.head1 = new Node(1);
            l.head1.next = new Node(2);
            l.head1.next.next = new Node(3);
            l.PrintList(l.head1);
            Console.WriteLine();
            l.head2 = new Node(4);
            l.head2.next = new Node(5);
            l.head2.next.next = new Node(6);
            l.PrintList(l.head2);

            Node result = null;
            result = l.SortedMerge(l.head1, l.head2);
            l.PrintList(result);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
