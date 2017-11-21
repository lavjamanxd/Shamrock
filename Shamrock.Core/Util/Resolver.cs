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

        public static void Register<T>(T instance) where T : class
        {
            _register[typeof(T)] = instance;
        }

        public static void Register<TKey, T>() where T : class
        {
            _register[typeof(TKey)] = Construct<T>();
        }

        public static T Resolve<T>() where T : class
        {
            return (T)_register[typeof(T)];
        }

        public static T Construct<T>() where T : class
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