using System;
using System.Collections.Generic;

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
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public bool CheckifPalindrome()
        {
            Node temp = head;
            bool palindrome = false;
            Stack<int> s = new Stack<int>();
            while(temp != null)
            {
                s.Push(temp.data);
                temp = temp.next;
            }
            while (head != null)
            {
                int data = s.Pop();
                if (head.data == data)
                {
                    head = head.next;
                    palindrome = true;
                }
                else
                {
                    head = head.next;
                    palindrome = false;
                    break;
                }

            }
            return palindrome;
        }
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Push(1);
            l.Push(2);
            l.Push(3);
            l.Push(4);
            l.Push(6);
            l.Push(2);
            l.Push(1);
            l.Print();
            Console.WriteLine();
            if (l.CheckifPalindrome())
                Console.WriteLine("palindrome");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
