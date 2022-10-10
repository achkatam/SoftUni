using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public Box()
        {
            Values = new List<T>();
        }

        public List<T> Values { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var value in Values)
            {
                sb.AppendLine($"{typeof(T)}: {value}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secIndex)
        {
            //T temp = Values[firstIndex];
            //Values[firstIndex] = Values[secIndex];
            //Values[secIndex] = temp;
            (Values[secIndex], Values[firstIndex]) = (Values[firstIndex], Values[secIndex]);
        }
    }
}
