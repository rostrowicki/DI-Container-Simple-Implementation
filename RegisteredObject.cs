using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.simpleioc.container
{
    public class RegisteredObject
    {
        public Type TypeToResolve { get; private set; }
        public Type ConcreteType { get; private set; }
        public LifeCycle LifeCycle { get; private set; }
        public object Instance { get; private set; }

        public RegisteredObject(Type tTypeToResolve, Type tConcrete, LifeCycle lifeCycle)
        {
            TypeToResolve = tTypeToResolve;
            ConcreteType = tConcrete;
            LifeCycle = lifeCycle;
        }

        public void CreateInstance(params object[] args)
        {
            Instance = Activator.CreateInstance(this.ConcreteType, args);
        }

    }
}
