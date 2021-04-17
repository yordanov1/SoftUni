using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;            
        }

        public string FirstName
        {
            get 
            {
                return this.firstName;
            } 
            private set 
            {
                this.firstName = value; 
            } 
        }
        public string LastName 
        {
            get
            {
                return lastName;
            }
            private set
            {
                this.lastName = value;
            } 
        }
        public int Age 
        {
            get 
            {
                return age;
            }
            private set
            {
                this.age = value;
            } 
        }

        public decimal Salary 
        {
            get
            {
                return this.salary;
            }
            private set 
            {
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recives {this.Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age >= 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
