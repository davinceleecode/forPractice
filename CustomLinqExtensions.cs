using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public static class CustomLinqExtensions
    {
        public static IEnumerable<TResult> customSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            List<TResult> results = new List<TResult>();
            foreach (TSource item in source)
            {
                results.Add(selector(item));
            }
            return results;

        }
    }

}
