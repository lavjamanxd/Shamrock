using System;
using System.Collections.Generic;
using System.Linq;
using Shamrock.Core._4Chan.Model;
using Shamrock.Core.ViewModel;

namespace Shamrock.Core.Util
{
    public static class Resolver
    {
        private static Dictionary<Type, object> _register = new Dictionary<Type, object>();

        public static void Register<T>(object instance)
        {
            _register[typeof(T)] = instance;
        }

        public static void Register<TKey, T>()
        {
            _register[typeof(TKey)] = Construct<T>();
        }

        public static T Resolve<T>()
        {
            return (T)_register[typeof(T)];
        }

        public static T Construct<T>()
        {
            return (T)ConstructObject(typeof(T));
        }

        public static object Construct(Type type)
        {
            return ConstructObject(type);
        }

        private static object ConstructObject(Type type)
        {
            return Activator.CreateInstance(type,
                type.GetConstructors().FirstOrDefault().GetParameters()
                    .Select(parameter => _register[parameter.ParameterType]).ToArray());
        }
    }
}