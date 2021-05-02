using Exer_05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer_05.FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name) : this()
        {
            this.Name = name;

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
                    throw new ArgumentException
                        (GlobalConstants.EmptyNameExceptionMessage);

                }
                this.name = value;
            }
        }

        public int Rating
        {
            get 
            {
                if (this.players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(this.players.Sum(p => 
                p.OveraLLSkill) / this.players.Count);
            }
        }
                     
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            Player playerToRemove = this.players
                .FirstOrDefault(p => p.Name == name);

            if (playerToRemove == null )
            {
                string excMsg = String.Format
                    (GlobalConstants.RemovingMissingPlayerExceptionMessage, name, this.Name);
                throw new InvalidOperationException(excMsg);
            }
            this.players.Remove(playerToRemove);           
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
