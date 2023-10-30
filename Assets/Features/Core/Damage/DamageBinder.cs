using Features.Core.Modifiers;
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
                enemyHealth = new HealthData {health = 100},
                CurrentCursor = new Cursor.Cursor
                {
                    Damage = new FlatModifier
                    {
                        Value = 5,
                        Type = ModifierType.Damage
                    },
                    CriticalDamage = new CoefficientModifier
                    {
                        Value = 2.0,
                        Type = ModifierType.CriticalDamage
                    },
                    CriticalChance = new CoefficientModifier
                    {
                        Value = 0.25,
                        Type = ModifierType.CriticalChance
                    }
                }
            };
            _model = new DamageModel();
            _model.Set(damageData);

            _controller = new DamageController();

            Binder.BindModelViewController(_model, view, _controller);
        }
    }
}