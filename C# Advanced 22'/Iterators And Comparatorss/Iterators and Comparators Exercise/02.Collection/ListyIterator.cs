using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;
        private List<T> _items;

        public ListyIterator(List<T> items)
        {
            _items = items;
        }

        public bool Move()
        {
            if (index + 1 < _items.Count)
            {
                index++;

                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (index == _items.Count - 1)
            {
                return false;
            }
            return true;
        }

        public void Print()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(_items[index]);
        }



        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
      
    }
}
