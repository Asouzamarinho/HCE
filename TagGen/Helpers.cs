using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

static class GetterHelper
{
    public static Expression<Action<T, PT>> ToSetter<T, PT>(this Expression<Func<T, PT>> getter)
    {
        var propertyParameter = Expression.Parameter(typeof(PT));

        return Expression.Lambda<Action<T, PT>>(Expression.Assign(getter.Body, propertyParameter), getter.Parameters[0], propertyParameter);
    }

    public static Expression<Action<PT>> ToSetter<PT>(this Expression<Func<PT>> getter)
    {
        var propertyParameter = Expression.Parameter(typeof(PT));

        return Expression.Lambda<Action<PT>>(Expression.Assign(getter.Body, propertyParameter), propertyParameter);
    }

    public static void SetValue<T, PT>(this Expression<Func<T, PT>> getter, T t, PT value)
    {
        getter.ToSetter().Compile()(t, value);
    }

    public static void SetValue<PT>(this Expression<Func<PT>> getter, PT value)
    {
        getter.ToSetter().Compile()(value);
    }
}

static class DoHelper
{
    public static void Do<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        for (var iterator = enumerable.GetEnumerator(); iterator.MoveNext();)
            action(iterator.Current);
    }

    public static void Do(this int i, Action<int> action)
    {
        Enumerable.Range(0, i).Do(action);
    }

    public static void Do<T>(this IEnumerable<T> enumerable, Action<T, int> action)
    {
        int i = 0;

        enumerable.Do(t => action(t, i++));
    }
}