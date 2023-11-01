using System;
using Features.Core.Ore;
using UnityEngine.Serialization;

namespace Features.Core.Damage
{
    [Serializable]
    public record DamageData()
    {
        public Cursor.Cursor currentCursor;
        public OreVein oreVein;
        public int currentOreVeinHealth;
    }
}