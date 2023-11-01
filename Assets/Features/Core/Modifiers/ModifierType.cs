using System;

namespace Features.Core.Modifiers
{
    [Serializable]
    public enum ModifierType
    {
        Luck,
        Damage,
        Health,
        CriticalDamage,
        CriticalChance,
        ExplorationChance
    }
}