using System;
using System.Collections;
using System.Collections.Generic;

namespace Array
{
    /// <summary>
    /// A LIFO (collection) implemented as an array
    /// </summary>
    /// /// <typeparam name="T"> The type of items contained in the stack </typeparam>
    public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {   
        /*************
        Initializing variables
        *************/
        private T[] _items = new T[0];
        private int _size = 0;

        /*
            Stack methods
        */
        #region Stack methods
        public void push(T item)
        {
            if (_size == _items.Length)
            {
                // We need to increase the size of our stack
                var newLength = _size == 0 ? 4 : _size * 2;

                T[] tmp = new T[newLength];
                _items.CoptyTo(tmp, 0);
                _items = tmp;
            }
            _items[_size] = item;
            _size++;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            _size--;
            return _items[_size];
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return _items[_size - 1];
        }

        public void Clear()
        {
            // This is problematic if the datatype held in the stack does not implement 
            // the IDisposable pattern.
            _size = 0;
        }
        #endregion Stack methods
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
