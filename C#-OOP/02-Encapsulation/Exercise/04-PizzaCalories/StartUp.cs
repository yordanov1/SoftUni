using Exer_04.PizzaCalories.Core;
using Exer_04.PizzaCalories.Ingredient;
using System;
using System.Linq;

namespace Exer_04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}
