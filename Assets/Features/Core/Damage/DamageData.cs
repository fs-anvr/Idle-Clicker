using System;

namespace Features.Core.Damage
{
    [Serializable]
    public record DamageData()
    {
        public HealthData enemyHealth;
        public Cursor.Cursor CurrentCursor;
    }
    
    [Serializable]
    public record HealthData()
    {
        public int health;
    }
}