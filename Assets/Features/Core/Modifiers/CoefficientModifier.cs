using System;

namespace Features.Core.Modifiers
{
    [Serializable]
    public record CoefficientModifier
    {
        public double value;
        public ModifierType type;
    }
}