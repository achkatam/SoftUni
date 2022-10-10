using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
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
