using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;

namespace Tulip.Framework.Common
{
    public class ObjectFactory
    {
        /// <summary>
        /// Gets the instance of the class which has implemented the specified interface.
        /// </summary>
        /// <param name="source">The source value required for instance creation.</param>
        /// <param name="operator">The operator value required for instance creation.</param>
        /// <returns>The instance of the class which has implemented the specified interface.</returns>
        public static T Get<T>(object source, OperatorType @operator) where T : IAssert
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.GetInterface(typeof(T).Name) != null)
                .FirstOrDefault();
            
            if (type != null)
            {
                if(type.IsGenericType)
                {
                    type = type.MakeGenericType(typeof(T).GetGenericArguments());
                }

                if(isValidCtor(type, new Type[] { source.GetType(), @operator.GetType() }))
                {
                    return (T)Activator.CreateInstance(type, source, @operator);
                }
                else
                {
                    var message = getInvalidCtorMessage(type, source.GetType(), @operator.GetType());
                    throw new AssertTypeNotFoundException(message);
                }
            }
            else
            {
                var message = getClassNotFoundMessage(typeof(T));
                throw new AssertTypeNotFoundException(message);
            }
        }
        
        private static bool isValidCtor(Type type, Type[] @params)
        {
            return type.GetConstructor(@params) != null ? true : false;
        }

        private static string getFullName(Type type)
        {
            if (type != null)
            {
                var fullName = $"{type.Namespace}.{type.Name}";

                if (type.IsGenericType)
                {
                    fullName = fullName.Remove(fullName.IndexOf("`"));
                    var genericParams = string.Join(", ", type.GetGenericArguments().Select(t => t.Name).ToArray());
                    fullName = $"{fullName}<{genericParams}>";
                }

                return fullName;
            }
            else
            {
                return null;
            }
        }

        private static string getInvalidCtorMessage(Type @class, Type source, Type @operator)
        {
            string message = null;

            message += $"The class '{getFullName(@class)}' is not having the required ctor. ";
            message += $"The class must have a public ctor accepting '{getFullName(source.GetType())}' ";
            message += $"and '{getFullName(@operator.GetType())}' as parameters.";

            return message;
        }

        private static string getClassNotFoundMessage(Type @interface)
        {
            string message = null;

            message += $"No class found in the current assembly ";
            message += $"which has implemented the '{getFullName(@interface)}' interface.";

            return message;
        }
    }
}
