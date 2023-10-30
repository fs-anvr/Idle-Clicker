using System.Collections.Generic;
using System.Linq;

namespace Features.Core.Modifiers
{
    public class ModifiersSystem
    {
        public static int CalculateFlat(List<FlatModifier> modifiers, ModifierType type)
        => modifiers
            .Where(m => m.Type == type)
            .Sum(m => m.Value);

        public static double CalculateCoefficient(List<CoefficientModifier> modifiers, ModifierType type)
        {
            var coefficient = modifiers
                .Where(m => m.Type == type)
                .Sum(m => m.Value);
            
            if (IsNegativeCoefficient(coefficient))
            {
                coefficient = 0.0d;
            }

            return coefficient;
        }

        public static Dictionary<int, double> CalculateDropChances(List<DropChanceModifier> modifiers)
        {
            var groupByItem = new Dictionary<int, double>();
            foreach (var m in modifiers)
            {
                if (!groupByItem.ContainsKey(m.ItemId))
                {
                    groupByItem[m.ItemId] = m.Chance;
                }
                else
                {
                    groupByItem[m.ItemId] *= m.Chance;
                }
            }

            return groupByItem;
        }

        private static double BaseCoefficient()
        {
            return 1.0d;
        }

        private static bool IsNegativeCoefficient(double value)
        {
            return value < 0.0d;
        }
    }
}