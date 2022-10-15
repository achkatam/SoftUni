using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare( Book firstBook, Book secondBook)
        {
            int result = firstBook.Title.CompareTo(secondBook.Title);
            if (result == 0)
            {
                if (firstBook.Year > secondBook.Year)
                {
                    return -1;
                }
                else if (firstBook.Year < secondBook.Year)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            return result;
        }
    }
}
