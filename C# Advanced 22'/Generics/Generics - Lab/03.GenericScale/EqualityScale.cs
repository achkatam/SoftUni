using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        //Create a class EqualityScale<T> that holds two elements – left and right. The scale should receive the elements through its single constructor:
        //•	EqualityScale(T left, T right)
        //The scale should have a single method: 
        //•	bool AreEqual()
        //The greater of the two elements is the heavier.The method should return true, if the elements are equal.
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right= right;
        }

        public bool AreEqual()
        {
            bool areEqual = this.left.Equals(this.right);

            return areEqual;
        }
    }
}
