using System;

namespace DeleteDLL
{
    class DLL
    {
        Node head;
        class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int d)
            {
                data = d;
                next = null;
                prev = null;
            }
        }
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            if(head != null)
                head.prev = new_node;

            new_node.prev = null;
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
        void Del(Node delNode)
        {
            if(head == delNode)
            {
                head = delNode.next;
            }
            if(delNode.next != null)
            {
                delNode.prev.next = delNode.next;
            }
            if (delNode.prev != null)
            {
                delNode.next.prev = delNode.prev;
            }
        }
        static void Main(string[] args)
        {
            DLL l = new DLL();
            l.Push(1);
            l.Push(2);
            l.Push(3);
            l.Push(4);
            l.Push(5);
            l.Print();
            l.Del(l.head.next);
            l.Print();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
