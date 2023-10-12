using Features.MVC;
using UnityEngine;

namespace Features.Core.Click
{
    public class ClickModel : Model<ClickData>
    {
        protected override void ModelUpdated()
        {
            Debug.Log("Click | Model");
            NotifyUpdate();
        }
    }
}