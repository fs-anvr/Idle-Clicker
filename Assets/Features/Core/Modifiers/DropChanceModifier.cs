using System;
using UnityEngine.Serialization;

namespace Features.Core.Modifiers
{
    [Serializable]
    public record DropChanceModifier
    {
        public int itemId;
        public int count;
        public double chance;
    }
}