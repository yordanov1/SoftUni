using Exer_05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_05.FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExceptionMessage);

                }
                this.name = value;
            }
        }

        public Stats Stats { get; }

        public double OveraLLSkill =>
            this.Stats.AverageStats;                                       
    }
}
