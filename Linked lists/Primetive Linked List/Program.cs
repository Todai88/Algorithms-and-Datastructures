using System;

namespace Linked_lists
{
    class Program
    {
        public class Node 
        {
            public int Value {get; set;}
            public Node next {get; set;}
        }
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 3 };
            Node second = new Node() { Value = 10 };
            first.next = second;

            Console.WriteLine(first.next.Value);
        }
    }
}
