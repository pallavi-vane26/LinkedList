using System;

namespace mergerAlternate
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
        static Node MergeAlternate(Node node1, Node node2)
        {
            Node res = null;
            if(node1 == null && node2 == null)
            {
                return null;
            }
            while(node1 != null && node2 != null)
            {
                Node firstNxt = node1.next;
                Node secNxt = node2.next;
                node1.next = secNxt;
                node2.next = firstNxt;
                node1 = node1.next;
                node2 = node2.next;
            }
            return res;
        }
        static void Print(Node temp)
        {
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.head1 = new Node(1);
            l.head1.next = new Node(2);
            l.head1.next.next = new Node(3);

            l.head2 = new Node(4);
            l.head2.next = new Node(5);
            l.head2.next.next = new Node(6);

            Node result = MergeAlternate(l.head1, l.head2);
            Print(result);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
