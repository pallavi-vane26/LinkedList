using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL2
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
        public void PrintList()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void PrintMiddleNode()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;
            if (head != null)
            {
                while (fast_ptr != null && fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("The middle element is : " +
                                    slow_ptr.data);
            }
        }
        int detectLoop()
        {
            Node slow_p = head, fast_p = head;
            while (slow_p != null && fast_p != null &&
                                    fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {
                    Console.WriteLine("Found loop");
                    return 1;
                }
            }
            return 0;
        }
        public bool CheckIfPalindrome()
        {
            Node temp = head;
            bool isPalin = true;
            Stack<int> s = new Stack<int>();
            while(temp != null)
            {
                s.Push(temp.data);
                temp = temp.next;
            }
            while(head != null)
            {
                int val = s.Pop();
                if (val == head.data)
                {
                    isPalin = true;
                }
                else
                {
                    isPalin = false;
                    //break;
                }
                head = head.next;
            }
            return isPalin;
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(3);
            list.Push(2);
            list.Push(1);
            
            //list.head.next.next.next.next = list.head;
            list.PrintMiddleNode();
            //bool isPal = list.CheckIfPalindrome();
            //Console.WriteLine("Palindrome : " + isPal);
            //list.detectLoop();
            Console.WriteLine("Final List is: ");
            list.PrintList();
            Console.ReadKey();
        }
    }
}
