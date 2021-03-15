using System;

namespace loop
{
    class LinkedList
    {
        Node head;
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
                Console.WriteLine(temp.data + "\t");
                temp = temp.next;
            }
        }
        public bool DetectLoop()
        {
            Node slow = head, fast = head;
            while(slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Push(5);
            l.Push(4);
            l.Push(3);
            l.Push(2);
            l.Push(1);
            l.PrintList();
            l.head.next.next.next.next = l.head;
            if(l.DetectLoop())
                Console.WriteLine("Loop detedted");
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
