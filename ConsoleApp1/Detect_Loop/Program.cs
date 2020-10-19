using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detect_Loop
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
            while(temp != null)
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
        //Using hash Table
        public bool DetectLoop()
        {
            Node temp = head;
            HashSet<Node> nodes = new HashSet<Node>();
            while(temp != null)
            {
                if (nodes.Contains(temp))
                {
                    return true;
                }
                nodes.Add(temp);
                temp = temp.next;
            }
            return false;
        }
        //Floyd cycle approach
        public bool CheckLoop()
        {
            Node fast_ptr = head;
            Node slow_ptr = head;
            while(fast_ptr.next != null && fast_ptr != null && slow_ptr!= null)
            {
                slow_ptr = slow_ptr.next;
                fast_ptr = fast_ptr.next.next;
                if (slow_ptr == fast_ptr)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.Push(1);
            l1.Push(2);
            l1.Push(3);
            l1.Push(4);
            l1.Push(5);
            l1.head.next.next = l1.head;
            if (l1.CheckLoop()){
                Console.WriteLine("Detected");
            }
            if (l1.DetectLoop())
            {
                Console.WriteLine("Loop Detected");
            }
            Console.ReadKey();
        }
    }
}
