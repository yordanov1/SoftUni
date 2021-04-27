using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_04.PizzaCalories.Ingredient
{
    public class Dough
    { 
        private string flourType; //white or wholegrain
        private string bakingTechnique; //crispy, chewy or homemade
        private double weight; //in grams

        public Dough(string flourTupe, string backingTechnique, double weght)
        {
            this.FlourType = flourTupe;
            this.BakingTechnique = backingTechnique;
            this.Weight = weght;
        }

        public string FlourType
        {
            get => this.flourType;

            private set 
            {
                if (value != "White" && value != "Wholegrain")
                {
                    Console.WriteLine(value);

                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set 
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CaloriesPerGram => 2 * this.Weight
                                           * this.GetFlourTypeModifier()
                                           * this.GetBakingTechniqueModifier();  

        private double GetFlourTypeModifier()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;
            }
            return 1.0;
        }

        private double GetBakingTechniqueModifier()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }
            else
            {
                return 1.0;
            }
        }    
    }
}
