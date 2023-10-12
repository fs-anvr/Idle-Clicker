namespace Features.MVC
{
    public abstract class Controller
    {
        public abstract void Process();
    }
    
    public abstract class Controller<T> : Controller
    {
        protected Model<T> Model;
        
        public void BindModel(Model<T> model)
        {
            Model = model;
        }

        public void UnbindModel()
        {
            Model = null;
        }
    }
}