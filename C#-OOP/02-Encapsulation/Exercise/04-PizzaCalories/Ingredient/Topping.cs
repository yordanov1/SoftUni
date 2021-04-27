using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_04.PizzaCalories.Ingredient
{
    public class Topping
    {
        string toppingTypeTest = "Cannot place {0} on top of your pizza.";
        string weightTestttt = "{0} weight should be in the range [1..50].";

        private string toppingTupe;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get => this.toppingTupe;

            private set
            {
                string test = value.ToLower();

                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException(String.Format(toppingTypeTest, value)); //!!!!!
                }
                this.toppingTupe = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format(weightTestttt, this.ToppingType));
                }
                this.weight = value;
            }
        }

        public double CalloriesPerGram => this.Callories() * this.Weight * 2;

        public double Callories()
        {
            if (this.ToppingType.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (this.ToppingType.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (this.ToppingType.ToLower() == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }
    }
}
