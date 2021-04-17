﻿using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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
        
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
