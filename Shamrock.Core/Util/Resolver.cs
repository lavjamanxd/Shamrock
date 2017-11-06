using System;
using System.Collections.Generic;
using System.Linq;

namespace Shamrock.Core.Util
{
    public static class Resolver
    {
        private static Dictionary<Type, object> _register = new Dictionary<Type, object>();

        public static void Register<TType>(object instance)
        {
            _register[typeof(TType)] = instance;
        }

        public static void Register<TType, TInstance>()
        {
            _register[typeof(TType)] = Construct<TInstance>();
        }

        public static TType Resolve<TType>()
        {
            return (TType)_register[typeof(TType)];
        }

        public static TType Construct<TType>()
        {
            return (TType)Activator.CreateInstance(typeof(TType),
                typeof(TType).GetConstructors().FirstOrDefault().GetParameters()
                    .Select(parameter => _register[parameter.ParameterType]).ToArray());
        }
    }
}