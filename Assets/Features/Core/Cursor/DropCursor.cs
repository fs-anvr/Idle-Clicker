using System.Collections.Generic;
using Features.Core.Modifiers;

namespace Features.Core.Cursor
{
    public class DropCursor : BaseCursor
    {
        public int Id;
        
        public FlatModifier Damage;
        public CoefficientModifier CriticalDamage;
        public CoefficientModifier CriticalChance;
        public DropChanceModifier DropChance;

        public override List<DropChanceModifier> CollectDropChances()
            => new()
            {
                DropChance
            };

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