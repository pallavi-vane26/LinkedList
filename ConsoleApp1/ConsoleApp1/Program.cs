using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null; 
            }
        }
        
        public void PrintList(Node head)
        {
            while(head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            if(head == null)
            {
                head = new Node(new_data);
                return;
            }
            new_node.next = null;
            Node last = head;
            while(last.next != null)
            {
                last = last.next;
            }
            last.next = new_node;
            return;
        }
        public void PushFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void InsertAfter(Node prev, int data)
        {
            Node new_node = new Node(data);
            if(prev != null)
            {
                new_node.next = prev.next;
                prev.next = new_node;    
            }
            
        }
        public void delete(int item)
        {
            Node prev = null;
            Node current = head;
            if (current == null)
                return;
            if(current != null && current.data == item)
            {
                head = current.next;
                return;
            }
            while(current != null && current.data != item)
            {
                prev = current;
                current = current.next;
            }
            prev.next = current.next;
        }
        public void DeleteAt(int position)
        {
            Node temp = head;
            if (position == 0)
            {
                head = head.next;
                return;
            }
            if (temp == null || temp.next == null)
                return;
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        public void GetCountIterative()
        {
            Node temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("count "+ count);
        }
        public int getCount(Node head)
        {
            if (head == null)
                return 0;
            return 1 + getCount(head.next);
        }
        public int getCountRecursive()
        {
            return getCount(head);
        }

        public void PrintNthFromLast(Node temp, int n)
        {
            int i = 0;
            if (temp == null)
                return;
            PrintNthFromLast(temp.next, n);
            if (++i == n)
                Console.WriteLine("nth form last " + temp.data);
        }
        public int PrintNthFromStart(Node temp, int n)
        {
            int count = 0;
            if (temp == null)
                return -1;
            if (count == n)
                return temp.data;
            return PrintNthFromStart(temp.next, n-1);
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //list.head = new Node(1);
            //list.head.next = new Node(2);
            //list.head.next.next = new Node(2);

            list.Append(1);
            list.Append(2);
            list.PushFront(3);
            list.PushFront(5);
            list.PushFront(6);
            list.PushFront(7);
            list.InsertAfter(list.head.next.next, 4);
            Console.WriteLine("recursive count" + list.getCountRecursive());
            list.delete(2);
            list.DeleteAt(5);
            list.GetCountIterative();
            list.PrintNthFromLast(list.head, 2);
            Console.WriteLine("nth form start - " + list.PrintNthFromStart(list.head, 2));
            list.PrintList(list.head);
            Console.ReadKey()
;        }
    }
}
