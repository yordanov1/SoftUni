using Exer_07.MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
