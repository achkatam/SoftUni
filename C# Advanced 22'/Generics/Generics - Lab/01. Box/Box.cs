using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Box
{
    public class Box<T>
    {
        //•	void Add(element) – adds an element on the top of the list.
        //•	element Remove() – removes the topmost element.
        //•	int Count { get; }

        private Stack<T> stack;

        public Box()
        {
            stack = new Stack<T>();
        }
        public void Add(T element)
        {
            stack.Push(element);
        }

        public T Remove()
        {
            return stack.Pop();
        }

        public int Count { get { return stack.Count; } }
    }
}
