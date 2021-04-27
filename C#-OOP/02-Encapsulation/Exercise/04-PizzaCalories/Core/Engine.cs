using Exer_04.PizzaCalories.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer_04.PizzaCalories.Core
{
    public class Engine
    {

        public void Run()
        {
            try
            {
                string[] inputPizza = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string namePizza = inputPizza[1];

                string[] inputDough = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .ToArray();

                string inputTopping = Console.ReadLine();

                string flourTupe = inputDough[1];
                string backingTechnique = inputDough[2];
                double weight = double.Parse(inputDough[3]);

                Dough dough = new Dough(flourTupe, backingTechnique, weight);

                Pizza pizza = new Pizza(namePizza, dough);

                while (inputTopping != "END")
                {
                    string[] toppingInfo = inputTopping.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string typeDough = toppingInfo[1];
                    double gramsDough = double.Parse(toppingInfo[2]); //double !!!!

                    Topping topping = new Topping(typeDough, gramsDough);

                    pizza.AddTopping(topping);

                    inputTopping = Console.ReadLine();
                }
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }        
        }
    }
}
