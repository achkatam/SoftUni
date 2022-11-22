namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;
        [SetUp]
        public void Setup()
        {
            this.db = new Database();
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Test_Constructor_Should_Initialize_Data_Correctly(int[] data)
        {
            //Arrange

            //Act
            Database db = new Database(data);
            //Assert
            int expectedCnt = data.Length;
            int actualCnt = db.Count;

            Assert.AreEqual(data.Length, db.Count);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 })]
        public void Test_Constructor_Should_Throw_Exception_When_Data_Is_Above_16(int[] data)
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                Database db = new Database(data);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Test_Constructor_Should_Add_Elements_Into_Data_Field(int[] data)
        {
            db = new Database(data);

            int[] expectedData = data;
            int[] actualData = db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Test_Count_Should_Return_Correct_Count(int[] data)
        {
            //Arrange
            db = new Database(data);

            //Act
            int expectedCount = data.Length;
            int actualCount = db.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Test_Adding_Elements_Should_Increase_Count()
        {
            //Arrange
            int expectedCount = 5;
            //Act
            for (int i = 0; i < expectedCount; i++)
            {
                this.db.Add(i);
            }

            int actualCount = db.Count;
            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Test_Adding_Elements_Should_Add_Them_In_Correct_Collection()
        {
            //Arrange
            int[] expectedData = new int[5];

            //Act
            for (int i = 1; i <= 5; i++)
            {
                this.db.Add(i);
                expectedData[i - 1] = i;
            }

            int[] actualData = this.db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void Test_AddingMoreThan16ElementsShouldThrowException()
        {

            //Act
            for (int i = 0; i < 16; i++)
            {
                this.db.Add(i);
            }

            //Full capacity has been reached
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Add(17);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void Test_Removing_Element_Should_Decrease_Count()
        {
            int initialCount = 5;
            for (int i = 0; i <= initialCount; i++)
            {
                this.db.Add(i);
            }

            int removeCount = 2;

            for (int i = 0; i <= removeCount; i++)
            {
                db.Remove();
            }
            int expectedCount = initialCount - removeCount;
            int actualCount = db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Test_Remove_Should_Remove_Element_Data_From_Collection()
        {
            int initialCount = 5;
            for (int i = 0; i <= initialCount; i++)
            {
                this.db.Add(i);
            }

            int removeCount = 2;

            for (int i = 0; i <= removeCount; i++)
            {
                this.db.Remove();
            }

            int[] expectedCount = new int[] {0, 1, 2 };
            int[] actualData = db.Fetch();

            Assert.AreEqual(expectedCount, actualData);
        }

        [Test]
        public void Test_RemoveShouldThrowExceptionWhenThereAreNoElementsInDB()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            }, "The collection is empty");
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Test_Fetch_ShouldReturnCorrectElements(int[] data)
        {
            db = new Database(data);

            int[] expectedData = data;
            int[] actualData = db.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}
