namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    using System.Text;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;


        [SetUp]
        public void Setup()
        {
            var people = new Person[15];

            for (int i = 0; i < people.Length; i++)
            {
                var sb = new StringBuilder();

                sb.Append("Smith");
                sb.Append(i.ToString());

                people[i] = new Person(1 + i, sb.ToString());
            }

            database = new Database(people);
        }

        [Test]
        public void TEST_CONSTRUCTOR_SHOULD_THROW_EXCEPTION_IF_EXCEEDED()
        {
            var people = new Person[20];

            for (int i = 0; i < people.Length; i++)
            {
                var sb = new StringBuilder();

                sb.Append("Smith");
                sb.Append(i.ToString());

                people[i] = new Person(1 + i, sb.ToString());
            }

            Assert.Throws<ArgumentException>(() =>
            {
                database = new Database(people);
            }, "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void TEST_ADD_METHOD_HOULD_INCREASE_ELEMENTS_COUNT()
        {
            database.Add(new Person(28, "Jeremy"));
            int expected = 16;
            int actual = database.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TEST_ADD_METHOD_SHOULD_THROW_EXCEPTION_IF_OUT_OF_RANGE()
        {
            database.Add(new Person(22, "Anthony"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(28, "Jeremy"));
            }, "Array's capacity must be exactly 16 integers!");

        }

        [Test]
        public void TEST_ADD_METHOD_SHOULD_THROW_EXCEPTION_IF_TRYING_TO_ADD_EXISTING_NAME()
        {
            Person personOne = new Person(1, "John");
            Person personTwo = new Person(2, "John");
            database = new Database();

            database.Add(personOne);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(personTwo);
            }, "There is already user with this username!");
        }

        [Test]
        public void TEST_ADD_METHOD_SHOULD_THROW_EXCEPTION_IF_TRYING_TO_ADD_EXISTING_ID()
        {
            Person personOne = new Person(1, "John");
            Person personTwo = new Person(1, "Harry");

            database = new Database();
            database.Add(personOne);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(personTwo);
            }, "There is already user with this Id!");
        }

        [Test]
        public void TEST_ADD_METHOD_SHOULD_ELEMENT_IN_COLLECTION()
        {
            Person person = new Person(14, "Angel");
            Database database = new Database();
            database.Add(person);

            Person expected = database.FindByUsername("Angel");

            Assert.AreEqual(expected, person);
        }

        [Test]
        public void TEST_REMOVE_METHOD_SHOULD_THROW_EXCEPTION_IF_COLLECTION_EMPTY()
        {
            database = new Database();

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void TEST_REMOVE_METHOD_SHOULD_DECREASE_ELEMENTS_COUNT()
        {
            Database database = new Database();
            database.Add(new Person(2, "Smith"));
            database.Add(new Person(3, "Karen"));

            int expected = database.Count - 1;
            database.Remove();

            int actual = database.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TEST_FINDBY_NAME_METHOD_SHOULD_THROW_EXCEPTION_IF_NAME_IS_NULL_OR_EMPTY(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername(name);
            }, "Username parameter is null!");
        }

        [TestCase("unKnown1")]
        [TestCase("unKnown2")]
        public void TEST_FINDBY_NAME_METHOD_SHOULD_THROW_EXCEPTION_IF_NAME_NONEXISTING(string name)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername(name);
            }, "No user is present by this username!");
        }

        [Test]
        public void TEST_FINDBYNAME_SHOULD_RETURN_VALID_PERSON()
        {
            Database database = new Database();
            database.Add(new Person(25, "Clarkson"));

            var actualPerson = database.FindByUsername("Clarkson");
            string expected = "Clarkson";

            Assert.AreEqual(expected, actualPerson.UserName);
        }

        [TestCase(-1)]
        [TestCase(-13)]
        public void TEST_FINDBYID_SHOULD_THROW_EXCEPTION_IF_NEGATIVE_ID(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(id);
            }, "Id should be a positive number!");
        }

        [Test]
        public void TEST_FINDBYID_SHOULD_THROW_EXCEPTION_IF_ID_NONEXISTING()
        {
            database = new Database();
            Person personOne = new Person(1, "John");
            Person personTwo = new Person(12, "Johny");
            Person personThree = new Person(13, "Mike");

            database.Add(personOne);
            database.Add(personTwo);
            database.Add(personThree);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindById(2);
            }, "No user is present by this ID!");
        }

        [Test]
        public void TEST_FINDBYID_SHOULD_RETURN_VALID_PERSON()
        {
            database = new Database();
            database.Add(new Person(12, "Steve"));

            int expected = 12;
            var actual = database.FindById(12);

            Assert.AreEqual(expected, actual.Id);
        }
    }
}