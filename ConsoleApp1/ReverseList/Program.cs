using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace MoveLastToFront
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace PairwiseSwap
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
                    while (temp != null)
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
                //Iterative approach
                public void Reverse()
                {
                    Node current = head;
                    Node prev = null;
                    Node next = null;
                    while(current != null)
                    {
                        next = current.next;
                        current.next = prev;
                        prev = current;
                        current = next;
                    }
                    head = prev;
                }

                //Using Stack
                public void ReverseUsingStack()
                {
                    Node temp = head;
                    Stack<Node> s = new Stack<Node>();
                    while(temp != null)
                    {
                        s.Push(temp);
                        temp = temp.next;
                    }
                   // Node current = null;
                    head = temp;
                    while(s.Count != 0)
                    {
                        head = s.Pop();

                        head = head.next;
                    }
                    head.next = null;
                    Print();
                }

                static void Main(string[] args)
                {
                    LinkedList l1 = new LinkedList();
                    l1.Push(7);
                    l1.Push(6);
                    l1.Push(5);
                    l1.Push(4);
                    l1.Push(3);
                    l1.Push(2);
                    l1.Push(1);
                    l1.Print();
                    Console.WriteLine("Swapped");
                    l1.Reverse();
                    l1.Print();
                    Console.WriteLine("Swapped using Stack");
                    l1.ReverseUsingStack();
                    //l1.Print();
                    Console.ReadKey();
                }
            }
        }

    }

}
