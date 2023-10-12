using Features.MVC;
using UnityEngine;

namespace Features.Core.Click
{
    public class ClickController : Controller<ClickData>
    {
        public override void Process()
        {
            LogMessage();
            Model.Set(Model.Get() with { IsClicked = true });
        }

        private static void LogMessage()
        {
            Debug.Log("Click | Controller");
        }
    }
}