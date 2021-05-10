using Exer_07.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName , decimal salary) :
            base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:F2}";
        }
    }
}
