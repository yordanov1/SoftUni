using Exer_04.PizzaCalories.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer_04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toping; 
        private Dough dough;

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toping = new List<Topping>();            
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public  Dough Dough { get; private set; } 
        public int NumberOfToppings => this.toping.Count;
        public double TotalClories => this.Dough.CaloriesPerGram + this.toping.Sum(t => t.CalloriesPerGram);

        public override string ToString()
        {            
            return $"{this.Name} - {this.TotalClories:f2} Calories.";
        }

        public void AddTopping(Topping topping)
        {
            if (toping.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toping.Add(topping);
        }
    }
}
