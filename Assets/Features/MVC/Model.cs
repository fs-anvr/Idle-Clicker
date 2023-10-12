using System;
using JetBrains.Annotations;

namespace Features.MVC
{
    public class Model {}
    
    public class Model<T> : Model
    {
        public delegate void ModelUpdateHandler(T data);
        [CanBeNull] public event ModelUpdateHandler Updated;
        
        protected T Data;
        
        public void Set(T data)
        {
            Data = data;
            ModelUpdated();
        }

        public T Get()
        {
            return Data;
        }

        protected virtual void ModelUpdated()
        {
            NotifyUpdate();
        }

        protected void NotifyUpdate()
        {
            Updated?.Invoke(Data);
        }
    }
}