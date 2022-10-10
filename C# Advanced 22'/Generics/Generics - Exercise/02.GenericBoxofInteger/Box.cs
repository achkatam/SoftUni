using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxofInteger
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
    }
}
