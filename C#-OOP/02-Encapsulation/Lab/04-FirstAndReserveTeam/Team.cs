using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;


        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public string Name { get; }
        public IReadOnlyList<Person> FirstTeam => this.firstTeam.AsReadOnly();                         
        public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam.AsReadOnly();


        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"First team has {this.FirstTeam.Count} players.");
            result.AppendLine($"Reserve team has {this.ReserveTeam.Count} players.");

            return result.ToString().TrimEnd();
        }
    }
}

