using System.Collections.Generic;
using Features.Core.Modifiers;

namespace Features.Core.Cursor
{
    public abstract class BaseCursor : IModifierCollectable
    {
        public virtual List<DropChanceModifier> CollectDropChances() => new();

        public virtual List<FlatModifier> CollectFlats() => new();

        public virtual List<CoefficientModifier> CollectCoefficients() => new();
    }
}