using System;

namespace Array
{
    /// <summary>
    /// A LIFO (collection) implemented as an array
    /// </summary>
    /// <typeparam name="T"> The type of items contained in the stack </typeparam>
    public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {   
        /*************
        Initializing variables:
        
        *************/
        private T[] _items = new T[0];
        private int _size = 0;
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
