using Features.Core.Modifiers;
using Features.Core.Ore;
using Features.MVC;
using UnityEngine;

namespace Features.Core.Damage
{
    public class DamageBinder : MonoBehaviour
    {
        [SerializeField] private DamageView view;
        private DamageController _controller;
        private DamageModel _model;

        private void Awake()
        {
            var damageData = new DamageData
            {
                currentOreVeinHealth = 100,
                currentCursor = new Cursor.Cursor
                {
                    Damage = new FlatModifier
                    {
                        Value = 5,
                        Type = ModifierType.Damage
                    },
                    criticalDamage = new CoefficientModifier
                    {
                        value = 2.0,
                        type = ModifierType.CriticalDamage
                    },
                    criticalChance = new CoefficientModifier
                    {
                        value = 0.25,
                        type = ModifierType.CriticalChance
                    }
                },
                oreVein = new OreVein
                {
                    
                }
            };
            _model = new DamageModel();
            _model.Set(damageData);

            _controller = new DamageController();

            Binder.BindModelViewController(_model, view, _controller);
        }
    }
}