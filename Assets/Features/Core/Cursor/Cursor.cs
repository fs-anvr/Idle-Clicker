﻿using System.Collections.Generic;
using Features.Core.Modifiers;

namespace Features.Core.Cursor
{
    public class Cursor : BaseCursor
    {
        public int Id;
        
        public FlatModifier Damage;
        public CoefficientModifier CriticalDamage;
        public CoefficientModifier CriticalChance;

        public override List<DropChanceModifier> CollectDropChances()
            => new();

        public override List<FlatModifier> CollectFlats()
            => new()
            {
                Damage
            };

        public override List<CoefficientModifier> CollectCoefficients()
            => new()
            {
                CriticalDamage,
                CriticalChance
            };
    }
}