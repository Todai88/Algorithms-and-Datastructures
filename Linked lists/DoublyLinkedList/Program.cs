using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    class Program
    {
        public class LinkedListNode<T>
        {
            public LinkedListNode(T value)
            {
                Value = value;
            }

            public T Value {get; set;}

            public LinkedListNode<T> Next {get; set;}

            public LinkedListNode<T> Previous { get; set; }
        }

        public class LinkedList<T> : 
            System.Collections.Generic.ICollection<T>
        {
            public LinkedListNode<T> Head
            {
                get;
                private set;
            }

            public LinkedListNode<T> Tail
            {
                get;
                private set;
            }

            int ICollection<T>.Count => throw new NotImplementedException();

            bool ICollection<T>.IsReadOnly => throw new NotImplementedException();
#region Add Methods
            public void AddFirst(T value)
            {
                AddFirst(new LinkedListNode<T>(value));
            }

            public void AddFirst(LinkedListNode<T> node)
            {
                // Keep current head in memory
                var tmp = Head;

                // Set the new value to the head
                Head = node;

                // Insert the rest behind the new node
                Head.Next = tmp;

                Count++;

                if (Count == 0)
                {
                    Head = Tail;
                }
                else
                {
                    tmp.Previous = Head;
                }
            }

            public void AddLast(T value)
            {
                AddLast(new LinkedListNode<T>(value));
            }

            public void AddLast(LinkedListNode<T> node)
            {
                if (Count == 0)
                {
                    Head = node;
                }
                else 
                {
                    Tail.Next = node;
                    node.Previous = Tail;
                }

                Tail = node;

                Count++;
            }
#endregion Add
#region Remove Methods
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else 
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            // Nothing to remove 
            if (Count != 0)
            {
                // If there is only one node, it's removed
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else 
                {
                    // Find the last node and remove it by iterating through nexts.
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
        }
#endregion Remove Methods
#region ICollection 
            public int Count 
            {
                get;
                private set;
            }
            void ICollection<T>.Add(T item)
            {
                AddFirst(item);
            }

            void ICollection<T>.Clear()
            {
                Head = null;
                Tail = null;
                Count = 0;
            }

            bool ICollection<T>.Contains(T item)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            void ICollection<T>.CopyTo(T[] array, int arrayIndex)
            {
                var current = Head;
                while(current != null)
                {
                    array[arrayIndex++] = current.Value;
                    current = current.Next;
                }
            }
            public bool IsReadOnly
            {
                get 
                {
                    return false;
                }
            }
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                LinkedListNode<T> current = Head;
                while (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
            }

            bool ICollection<T>.Remove(T item)
            {
                LinkedListNode<T> previous = null;
                var current = Head;

                while(current != null)
                {
                    // Found it
                    if (current.Value.Equals(item))
                    {
                        if (previous != null)
                        {
                            // Before Remove(6): 3 -> 7 -> 6 -> null
                            // After  Remove(6): 3 -> 7 ------> null
                            previous.Next = current.Next;

                            if (current.Next == null)
                            {
                                Tail = previous;
                            }

                            Count--;
                        }
                        else
                        {
                            RemoveFirst();
                        }
                        return true;
                    }

                previous = current;
                current = current.Next;
                }
                return false;
            }
        }
#endregion ICollection
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
