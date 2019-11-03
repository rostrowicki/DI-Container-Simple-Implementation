using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.simpleioc.container
{
    interface IContainer
    {        
        void Register<TTypeToResolve, TConcrete>();
        void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle);
        object Resolve(Type typeToResolve);
    }
}
