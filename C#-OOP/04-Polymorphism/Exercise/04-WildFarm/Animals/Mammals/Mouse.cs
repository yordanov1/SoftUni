using Exer_04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_04.WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifier = 0.10;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {            
            nameof(Vegetable),
            nameof(Fruit)            
        };

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, allowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public Mouse(string name, double weight, HashSet<string> allowedFoods, double weightModifier, string livingRegion) 
            : base(name, weight, allowedFoods, weightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
