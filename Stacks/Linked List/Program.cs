using System;
using System.Collections;
using System.Collections.Generic;

namespace Linked_List
{
    public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {
        private System.Collections.Generic.LinkedList<T> _list =
            new System.Collections.Generic.LinkedList<T>();

        public int Count 
        {
            get 
            {
                return _list.Count;
            }
        }

        public void Clear()
        {
            _list.Clear();
        }
        
        #region Stack methods
        /// <summary>
        /// Pushes an item to the front of the list.
        /// </summary>
        /// <param name="item"></param>
        public void Push (T item)
        {
            _list.AddFirst(item);
        }

        /// <summary>
        /// Uses the Peek method to return and remove the first item in the Linked list
        /// </summary>
        /// <returns></returns>
        public T Pop() 
        { 
            var value = Peek();
            _list.RemoveFirst();
            return value;
        }

        /// <summary>
        /// Peeks to the front of the Linked List, if an item exists, its value is returned, 
        /// otherwise an exception is thrown.
        /// </summary>
        /// <returns> The first item in the LL, or an exception if stack is empty </returns>
        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _list.First.Value;
        }

        #endregion Stack methods

        #region IEnumerable methods 

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        #endregion IEnumerable methods
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
