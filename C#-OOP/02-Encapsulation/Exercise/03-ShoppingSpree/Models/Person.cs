

using Exer_03.ShoppingSpree.Common;
using System;
using System.Collections.Generic;

namespace Exer_03.ShoppingSpree.Models
{
    public class Person
    {
        private const decimal MONEY_MIN_VALUE = 0;

        private string name;
        private decimal money;
        private List<Product> bag;

        public Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money) : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessege);
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < MONEY_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMOneyExeptionMessage);
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly(); 

        public void ByeProdyct(Product prodyct)
        {
            if (this.Money < prodyct.Cost)
            {
                throw new InvalidOperationException(String.Format
                    (GlobalConstants.InsufficientMoneyExceptionMassage, 
                    this.Name, prodyct.Name)); 
            }
            this.Money -= prodyct.Cost;
            this.bag.Add(prodyct);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ?
                String.Join(", ", this.Bag) : "Nothing bought";

            return $"{this.Name} - {productsOutput}";
        }
    }
}
