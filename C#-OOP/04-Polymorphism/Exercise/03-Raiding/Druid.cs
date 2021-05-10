using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.Raiding
{
    class Druid : BaseHero
    {
        private const int BasePower = 80;

        public Druid(string name)
            : base(name, BasePower)
        {

        }

        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {Name} healed for {Power}";
        }
    }
}
