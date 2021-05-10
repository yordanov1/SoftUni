using Exer_07.MilitaryElite.Contracts;
using Exer_07.MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {

        private List<IMission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps)
            :base (id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }


        public IReadOnlyCollection<IMission> Mission => this.missions.AsReadOnly();

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("Missions:");

            foreach (var mission in this.Mission)
            {
                sb.AppendLine($"  {mission}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
