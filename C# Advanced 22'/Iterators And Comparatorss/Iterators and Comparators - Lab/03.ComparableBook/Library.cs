﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }


        public IEnumerator<Book> GetEnumerator()// => new LibraryIterator(books);
        {
            books.Sort();

            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(SortedSet<Book> books)
            {
                Reset();
                this.books = new List<Book>(books.ToList());
            }
            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < books.Count;
            }
            public Book Current => books[currentIndex];
            object IEnumerator.Current => Current;
            public void Reset() => currentIndex = -1;

            public void Dispose() { }
        }
    }
}