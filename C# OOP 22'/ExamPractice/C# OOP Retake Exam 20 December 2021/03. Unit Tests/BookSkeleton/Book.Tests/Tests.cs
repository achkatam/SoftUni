namespace Book.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;

    public class Tests
    {
        private Book book;
        private Dictionary<int, string> footnote;

        [SetUp]
        public void SetUp()
        {
            book = new Book("Harry Potter", "J.K.Rowling");
            footnote = new Dictionary<int, string>();
        }

        [Test]
        public void Test_Constructor_Set_Data_Correctly()
        {
            string expected = "Harry Potter";
            string expectedAuthor = "J.K.Rowling";

            Assert.AreEqual(expected, book.BookName);
            Assert.AreEqual(expectedAuthor, book.Author);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_Constructor_Throws_Exception_WhenNameNullOrEmpty(string bookName)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                book = new Book(bookName, "Lqlq");
            });
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_Constructor_Throws_Exception_WhenAuthorNullOrEmpty(string bookAuthor)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                book = new Book("Lqlq", bookAuthor);
            });
        }

        [Test]
        public void Test_FootnoteCountReturnDictionaryCount()
        {
            int expected = 0;

            Assert.AreEqual(expected, footnote.Count);
        }

        [Test]
        public void Test_AddFootnoteCountReturnDictionaryCount()
        {
            int expected = 2;

            for (int i = 0; i < expected; i++)
            {
                book.AddFootnote(i, i.ToString());
            }
            Assert.AreEqual(expected, book.FootnoteCount);
        }

        [TestCase(23)]
        [TestCase(2)]
        [TestCase(34)]
        public void Test_AddFootnoteThrowsExceptionIfKeyExisted(int footNoteNumber)
        {
            book.AddFootnote(footNoteNumber, "123");

            Assert.Throws<InvalidOperationException>(() =>
            {
                book.AddFootnote(footNoteNumber, "2133");
            });
        }

        [TestCase(2)]
        [TestCase(34)]
        public void Test_FindFootnoteThrowsExceptionIfKeyNonExisting(int footNoteNumber)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                book.FindFootnote(footNoteNumber);
            });
        }

        [Test]
        public void Test_FindFootnoteReturnsNote()
        {
            int key = 1;
            string text = "Text";

            book.AddFootnote(key, text);

            string expectedResult = $"Footnote #{key}: {text}";

            Assert.AreEqual(expectedResult, book.FindFootnote(key));
        }

        [TestCase(2)]
        [TestCase(34)]
        public void Test_AlterdFootnoteThrowsExceptionIfKeyNonExisting(int footNoteNumber)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                book.AlterFootnote(footNoteNumber, "text");
            });
        }

        [Test]
        public void Test_AlterdFootnoteShouldChangeTheValue()
        {
            int key = 1;
            string value = "text1";
            book.AddFootnote(key, value);

            string expectedText = "text2";
            book.AlterFootnote(key, expectedText);

            Type bookType = this.book.GetType();
            FieldInfo dictFieldInfo = bookType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(x => x.Name == "footnote");

            var fieldValue = (Dictionary<int, string>)dictFieldInfo.GetValue(book);

            string actualText = fieldValue[key];

            Assert.AreEqual(expectedText, actualText);
        }
    }
}