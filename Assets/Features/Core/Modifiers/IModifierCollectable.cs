using System.Collections.Generic;

namespace Features.Core.Modifiers
{
    public interface IModifierCollectable
    {
        public List<DropChanceModifier> CollectDropChances();
        public List<FlatModifier> CollectFlats();
        public List<CoefficientModifier> CollectCoefficients();
    }
}