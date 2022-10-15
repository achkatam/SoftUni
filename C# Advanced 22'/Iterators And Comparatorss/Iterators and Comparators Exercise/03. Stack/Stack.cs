using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03._Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] _items;

        public Stack()
        {
            _items = new T[InitialCapacity]; 
        }
        public int Count { get; private set; }
        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                Resize();
            }

            _items[Count] = item;

            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T removedItem = _items[Count - 1];

            Count--;

            return removedItem;
        }

        private void Resize()
        {
            T[] copy = new T[_items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = _items[i];
            }

            _items = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
    }
}
