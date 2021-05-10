﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Contracts
{
    public interface ICommando
    {
        IReadOnlyCollection<IMission> Mission { get; }

        void AddMission(IMission mission);
    }
}
