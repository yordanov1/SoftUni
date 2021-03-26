using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemon)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemon = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemon { get; set; }
    }
}
