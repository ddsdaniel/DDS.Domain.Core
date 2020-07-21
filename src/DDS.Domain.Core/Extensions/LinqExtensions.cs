using System;
using System.Collections.Generic;
using System.Linq;

namespace DDS.Domain.Core.Extensions
{
    public static class LinqExtensions
    {
        public static int MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, int defaultValue)
            => source.Any() ? source.Max(selector) : defaultValue;

        public static int MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
            => MaxOrDefault(source, selector, 0);

        public static IEnumerable<TSource> Move<TSource>(this IEnumerable<TSource> source, int from, int to)
        {
            var list = source.ToList();
            var item = list[from];
            list.RemoveAt(from);
            list.Insert(to, item);
            return list;
        }

    }
}
