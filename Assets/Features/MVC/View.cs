using UnityEngine;

namespace Features.MVC
{
    public abstract class View<T> : MonoBehaviour
    {
        protected Model<T> ObservedModel;
        protected Controller Controller;
        
        public void BindModel(Model<T> model)
        {
            UnbindModel();
            ObservedModel = model;
            ObservedModel.Updated += UpdateView;
        }

        public void UnbindModel()
        {
            if (ObservedModel is null)
            {
                return;
            }
            
            ObservedModel.Updated -= UpdateView;
            ObservedModel = null;
        }

        public void BindController(Controller controller)
        {
            Controller = controller;
        }

        public void UnbindController()
        {
            if (Controller is null)
            {
                return;
            }
            
            Controller = null;
        }

        protected abstract void UpdateView(T data);
    }
}