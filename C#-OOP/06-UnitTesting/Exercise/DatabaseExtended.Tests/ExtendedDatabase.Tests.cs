
using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendetDatabase;

        [SetUp]
        public void Setup()
        {
            this.extendetDatabase = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Add_ThrowsExceptions_WhenCapacityIsExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                this.extendetDatabase.Add(new Person(i, $"Username{i}"));
            }

            Assert.Throws<InvalidOperationException>(() =>
            this.extendetDatabase.Add(new Person(16, "InvalidUsername")));
        }

        [Test]
        public void Add_ThrowsException_WhenUserisUsed()
        {
            string username = "Dimitrichko";

            this.extendetDatabase.Add(new Person(1, username));

            Assert.Throws<InvalidOperationException>(() =>
            this.extendetDatabase.Add(new Person(2, username)));                                    
        }

        [Test]
        public void Add_ThrowsExceptions_WhenIdIsUsed()
        {
            this.extendetDatabase.Add(new Person(1, "username"));

            Assert.Throws<InvalidOperationException>(() =>
            this.extendetDatabase.Add(new Person(1, "username2")));
        }

        [Test]
        public void Add_IncreaseCounter_WhenUserIsValid()
        {
            this.extendetDatabase.Add(new Person(1, "Dimitrichko"));
            this.extendetDatabase.Add(new Person(2, "Stoyan"));

            int expectedCount = 2;

            Assert.That(this.extendetDatabase.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_ThrowsException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendetDatabase.Remove());
        }

        [Test]
        public void Remove_RemoveElementFromDatabase()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                this.extendetDatabase.Add(new Person(i, $"Username{i}"));
            }

            this.extendetDatabase.Remove();

            Assert.That(this.extendetDatabase.Count, Is.EqualTo(n - 1));
            Assert.Throws<InvalidOperationException>(() => this.extendetDatabase.FindById(n - 1));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ThrowException_WhenArgumentIsNotValid(string username)
        {
            Assert.Throws<ArgumentNullException>(() => this.extendetDatabase.FindByUsername(username));
        }

        [Test]       
        public void FindBuUsername_ThrowsException_WhenUsernameDoesNOtExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendetDatabase.FindByUsername("Username"));
        }

        [Test]
        public void FindByUsername_ReturnAcceptedUser_WhenUSerExist()
        {
            Person person = new Person(1, "Dimitrichko");

            this.extendetDatabase.Add(person);

            Person dbPerson = this.extendetDatabase.FindByUsername(person.UserName);

            Assert.That(person, Is.EqualTo(dbPerson));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-25)]
        public void FindById_ThrowsException_WhenIsLessThanZero(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.extendetDatabase.FindById(id));
        }

        [Test]       
        public void FindById_ThrowsException_WhenUserWithIdDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendetDatabase.FindById(101));
        }

        [Test]
        public void FindID_ReturnsExpectedUser_WhenUserExists()
        {
            Person person = new Person(1, "Dimitrichko");

            this.extendetDatabase.Add(person);

            Person dbPeson = this.extendetDatabase.FindById(person.Id);

            Assert.That(person, Is.EqualTo(dbPeson));
        }
        [Test]
        public void Ctor_ThrowsException_WhenCapacityISExceeded()
        {
            Person[] arguments = new Person[17];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }

            Assert.Throws<ArgumentException>(() => this.extendetDatabase = new ExtendedDatabase.ExtendedDatabase(arguments));
        }

        [Test]
        public void Ctor_AddInitialPeopleToDatabase()
        {
            Person[] arguments = new Person[5];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }

            this.extendetDatabase = new ExtendedDatabase.ExtendedDatabase(arguments);

            Assert.That(this.extendetDatabase.Count, Is.EqualTo(arguments.Length));

            foreach (var person in arguments)
            {
                Person dbPerson = this.extendetDatabase.FindById(person.Id);
                Assert.That(person, Is.EqualTo(dbPerson));
            }
        }
    }
}