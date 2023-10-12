namespace Features.MVC
{
    public class Binder
    {
        public static void BindModelViewController<T>(Model<T> model, View<T> view, Controller<T> controller)
        {
            BindViewController(view, controller);
            BindModelView(model, view);
            BindModelController(model, controller);
        }

        public static void BindModelView<T>(Model<T> model, View<T> view)
        {
            view.BindModel(model);
        }

        public static void BindModelController<T>(Model<T> model, Controller<T> controller)
        {
            controller.BindModel(model);
        }

        public static void BindViewController<T>(View<T> view, Controller<T> controller)
        {
            view.BindController(controller);
        }
    }
}