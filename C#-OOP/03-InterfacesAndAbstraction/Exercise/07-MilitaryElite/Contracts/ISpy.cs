using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Contracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
