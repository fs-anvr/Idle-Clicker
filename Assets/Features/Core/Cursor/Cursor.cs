using System.Collections.Generic;
using Features.Core.Modifiers;

namespace Features.Core.Cursor
{
    public class Cursor : IModifierCollectable
    {
        public FlatModifier Damage;
        public CoefficientModifier CriticalDamage;
        public CoefficientModifier CriticalChance;

        public List<DropChanceModifier> CollectDropChances()
            => new();

        public List<FlatModifier> CollectFlats()
            => new()
            {
                Damage
            };

        public List<CoefficientModifier> CollectCoefficients()
            => new()
            {
                CriticalDamage,
                CriticalChance
            };
    }
}