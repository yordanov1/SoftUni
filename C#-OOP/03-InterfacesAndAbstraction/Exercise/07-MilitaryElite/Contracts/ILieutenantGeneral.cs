using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.MilitaryElite.Contracts
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate @private);
    }
}
