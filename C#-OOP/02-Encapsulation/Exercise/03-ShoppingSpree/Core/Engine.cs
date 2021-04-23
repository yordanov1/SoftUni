﻿using Exer_03.ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer_03.ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProduct();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = cmdArgs[0];
                string productName = cmdArgs[1];

                try
                {
                    Person person = this.people.First(p => p.Name == personName);
                    Product product = this.products.First(p => p.Name == productName);

                    person.ByeProdyct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }

            foreach ( Person person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddProduct()
        {
            string[] productArgs = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < productArgs.Length; i++)
            {
                string[] currProductTokens = productArgs[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currProductTokens[0];
                decimal cost = decimal.Parse(currProductTokens[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] peopleArgs = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < peopleArgs.Length; i++)
            {
                string[] currPeopleTokens = peopleArgs[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = currPeopleTokens[0];
                decimal money = decimal.Parse(currPeopleTokens[1]);

                Person person = new Person(name, money);

                this.people.Add(person);
            }
        }
    }
}
