using System;
using System.Collections.Generic;
using System.Text;

namespace CustomHashSet
{
    class SoftUniHashSet
    {
        private List<string>[] internalArray;

        public SoftUniHashSet(int capacity)
        {
            internalArray = new List<string>[capacity];
        }

        public void Add(string value)
        {
            int index = HashFunc(value);
            if (internalArray[index] == null)
            {
                internalArray[index]= new List<string>();
            }

            internalArray[index].Add(value);
        }
        public bool Contains(string value)
        {
            int index = HashFunc(value);

            for (int i = 0; i < internalArray[index].Count; i++)
            {
                if (internalArray[index][i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int HashFunc(string value)
        {
            return (int)value[0] % internalArray.Length;
        }
    }
}
