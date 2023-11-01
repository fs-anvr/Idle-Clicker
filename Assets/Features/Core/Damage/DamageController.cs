using Features.Core.Modifiers;
using Features.MVC;
using UnityEngine;

namespace Features.Core.Damage
{
    public class DamageController : Controller<DamageData>
    {
        public override void Process()
        {
            var data = Model.Get();
            var damage = CalculateDamage(data);
            var processedData = ProcessHealth(data, damage);
            Model.Set(processedData);
        }

        private static double CalculateDamage(DamageData data)
        {
            var criticalChance = GetCriticalChance(data.currentCursor);
            var damage =
                Roll(criticalChance) ?
                    GetCriticalDamage(data.currentCursor) :
                    GetDamage(data.currentCursor);

            return damage;
        }

        private static DamageData ProcessHealth(DamageData data, double damage)
        {
            var enemyHealth = data.currentOreVeinHealth; // * levelOreFlatHealth
            var newHealthData = data with { currentOreVeinHealth = enemyHealth - (int)damage };
            return newHealthData;
        }
        
        private static int GetDamage(Cursor.Cursor cursor)
            => ModifiersSystem.CalculateFlat(cursor.CollectFlats(), ModifierType.Damage);

        private static double GetCriticalChance(Cursor.Cursor cursor)
            => ModifiersSystem.CalculateCoefficient(cursor.CollectCoefficients(), ModifierType.CriticalChance);

        private static double GetCriticalCoefficient(Cursor.Cursor cursor)
            => ModifiersSystem.CalculateCoefficient(cursor.CollectCoefficients(), ModifierType.CriticalDamage);

        private static double GetCriticalDamage(Cursor.Cursor cursor)
            => GetDamage(cursor) * GetCriticalCoefficient(cursor);

        private static bool Roll(double chance)
        {
            var rolledValue = Random.Range(0.0f, 1.0f);
            return chance >= rolledValue;
        }
    }
}