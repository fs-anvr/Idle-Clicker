using Features.MVC;
using UnityEngine;
using UnityEngine.UI;

namespace Features.Core.Damage
{
    public class DamageView : View<DamageData>
    {
        [SerializeField] private Button button;
        protected override void UpdateView(DamageData data)
        {
            Debug.Log("Текущее здоровье цели: " + data.enemyHealth);
        }
        
        private void Awake()
        {
            button.onClick.AddListener(Click);
        }

        private void Click()
        {
            Controller.Process();
        }
    }
}