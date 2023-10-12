using System;
using Features.MVC;
using UnityEngine;
using UnityEngine.UI;

namespace Features.Core.Click
{
    public class ClickView : View<ClickData>
    {
        [SerializeField] private Button button;
        protected override void UpdateView(ClickData data)
        {
            if (data.IsClicked)
            {
                Debug.Log("Click | View");
            }
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