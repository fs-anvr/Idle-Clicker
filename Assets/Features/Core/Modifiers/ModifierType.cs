using System;

namespace Features.Core.Modifiers
{
    [Serializable]
    public enum ModifierType
    {
        Damage,
        Health,
        CriticalDamage,
        CriticalChance,
        ExplorationChance
    }
}