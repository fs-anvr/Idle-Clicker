using System;
using System.Collections.Generic;
using Features.Core.Modifiers;

namespace Features.Core.Ore
{
    [Serializable]
    public record OreVein : IModifierCollectable
    {
        public int levelForExploration;
        public CoefficientModifier explorationChance;
        public CoefficientModifier healthCoefficient;
        public DropChanceModifier oreReward;
        public DropChanceModifier itemDrop;


        public List<DropChanceModifier> CollectDropChances()
            => new()
            {
                oreReward,
                itemDrop
            };

        public List<FlatModifier> CollectFlats()
            => new();

        public List<CoefficientModifier> CollectCoefficients()
            => new()
            {
                healthCoefficient,
                explorationChance
            };
    }
}