using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace CustomDoublyLinkedList
{
    //this class hold the entire list /head + tail + operations/
    public class DoublyLinkedList : QuickSort
    {
        private Node head;
        private Node tail;
        // private Node pivot;

        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PreviousNode { get; set; }

        }


        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newTail = new Node(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public int RemoveFirst()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var firstElement = head.Value;
            head = head.NextNode;

            if (head != null)
            {
                head.PreviousNode = null;
            }
            else
            {
                tail = null;
            }

            Count--;

            return firstElement;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            var lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }
            Count--;

            return lastElement;
        }

        public void Foreach(Action<int> action)
        {
            var currNode = head;

            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] arr = new int[Count];
            int cnt = 0;
            var currNode = head;

            while (currNode != null)
            {
                arr[cnt] = currNode.Value;
                currNode = currNode.NextNode;
                cnt++;
            }

            return arr;
        }


    }
}
