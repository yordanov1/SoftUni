using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database();
        }

        [Test]
        public void Throw_ThrowsException_WhenCapacityIsExeeded()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }
        [Test]
        public void Add_IncreaseDatabaseCount_WhenAddIsValidOperation()
        {
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                this.database.Add(324);
            }

            Assert.That(this.database.Count, Is.EqualTo(n));
        }
        
        [Test]
        public void Add_AddsElementToDatabase()
        {
            int element = 324;
            
            this.database.Add(element);

            int[] elements = this.database.Fetch();

            Assert.IsTrue(elements.Contains(element));
        }    

        [Test]
        public void Remove_ThrowsException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void Remove_DecricesDatabaseCount()
        {
            this.database.Add(1);
            this.database.Add(2);
            this.database.Add(3);

            this.database.Remove();

            Assert.That(this.database.Count, Is.EqualTo(2));
        }

        [Test]
        public void Remove_DecricesElementFromDatabase()
        {
            int lastElement = 3;

            this.database.Add(1);
            this.database.Add(2);
            this.database.Add(lastElement);

            this.database.Remove();

            int[] elements = this.database.Fetch();

            Assert.IsFalse(elements.Contains(lastElement));
        }

        [Test]
        public void Fetch_ReturnsDatabaseCopyInsteadOfReference()
        {
            this.database.Add(1);
            this.database.Add(2);

            int[] firstCopy = this.database.Fetch();

            this.database.Add(3);

            int[] secondCopy = this.database.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));
        }

        [Test]
        public void Count_ReturnZero_ThenDatabaseIsEmpty()
        {
            Assert.That(this.database.Count, Is.EqualTo(0));
        }

        [Test]
        public void Ctor_ThrowsExceptionWhenDatabaseCapacityISExceeteded()
        {
            Assert.Throws<InvalidOperationException>(() => 
            this.database = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7));
        }

        [Test]
        public void Ctor_AddsElementToDatabase()
        {
            int[] arr = { 1, 2, 3 };
            this.database = new Database.Database(arr);

            Assert.That(this.database.Count, Is.EqualTo(arr.Length));
            Assert.That(this.database.Fetch(), Is.EquivalentTo(arr));
        }
    }
}