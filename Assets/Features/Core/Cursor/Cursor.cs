using System;
using System.Collections.Generic;
using Features.Core.Modifiers;
using UnityEngine.Serialization;

namespace Features.Core.Cursor
{
    [Serializable]
    public class Cursor : BaseCursor
    {
        public int id;
        
        public FlatModifier Damage;
        public CoefficientModifier criticalDamage;
        public CoefficientModifier criticalChance;

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
                criticalDamage,
                criticalChance
            };
    }
}