using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.simpleioc.container
{
    class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException()
        {

        }

        public TypeNotRegisteredException(string message) : base(message)
        {

        }

        public TypeNotRegisteredException(string message, Exception inner): base(message, inner)
        {

        }
    }
}
