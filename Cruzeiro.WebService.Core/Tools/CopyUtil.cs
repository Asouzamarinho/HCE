using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cruzeiro.WebService.Core.Tools
{
    public static class CopyUtil
    {
        public static void Copy(object from, object to)
        {
            var fromType = from.GetType();
            var fromProperties = fromType.GetProperties().Where(_ => _.CanRead).Select(_ => _.Name).ToArray();
            var toType = to.GetType();
            var toProperties = toType.GetProperties().Where(_ => _.CanWrite).Select(_ => _.Name).ToArray();
            var properties = fromProperties.Intersect(toProperties).ToArray();
            foreach (var name in properties)
            {
                var propertyFrom = fromType.GetProperty(name);
                var propertyTo = toType.GetProperty(name);

                if (propertyFrom != null && propertyTo != null)
                {
                    var fromValue = propertyFrom.GetValue(@from, null);
                    var fromColletion = fromValue as ICollection;
                    if (fromColletion == null)
                    {
                        if (propertyTo.PropertyType.IsAssignableFrom(typeof (string)) &&
                            !propertyFrom.PropertyType.IsAssignableFrom(typeof (string)))
                        {
                            propertyTo.SetValue(to, fromValue.ToString(), null);
                        }
                        else if (!propertyTo.PropertyType.IsAssignableFrom(typeof (string)) &&
                                 propertyFrom.PropertyType.IsAssignableFrom(typeof (string)))
                        {
                            if (propertyTo.PropertyType.IsAssignableFrom(typeof (int)))
                            {
                                propertyTo.SetValue(to, int.Parse((string) fromValue), null);
                            }
                            else
                            {
                                throw new TypeLoadException();
                            }
                        }
                        else
                        {
                            if (fromValue == null)
                            {
                                if (propertyTo.PropertyType.IsGenericType &&
                                    propertyTo.PropertyType.GetGenericTypeDefinition() == typeof (Nullable<>))
                                {
                                    propertyTo.SetValue(to, null);
                                }
                            }
                            else
                            {
                                propertyTo.SetValue(to,
                                    propertyTo.PropertyType.IsInstanceOfType(fromValue)
                                        ? fromValue
                                        : Convert.ChangeType(fromValue, propertyTo.PropertyType));
                            }
                        }
                    }
                    else
                    {
                        if (propertyFrom.PropertyType == propertyTo.PropertyType)
                        {
                            propertyTo.SetValue(to, propertyFrom.GetValue(from));
                        }
                    }
                }
            }
        }

        public static object CopyFrom(this object to, object from)
        {
            Copy(from, to);
            return to;
        }

        public static object CopyTo(this object from, object to)
        {
            Copy(from, to);
            return from;
        }

        public static T ConvertToBean<T>(this object from)
        {
            var to = Activator.CreateInstance<T>();
            return (T) to.CopyFrom(@from);
        }

        public static IEnumerable<T> ConvertToBean<T>(this IEnumerable<object> from)
        {
            return from.Select(_ =>
                               {
                                   var to = Activator.CreateInstance<T>();
                                   return (T) to.CopyFrom(_);
                               });
        }
    }
}