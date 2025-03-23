using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice
{
    public static class tobedeleteExtension
    {

        public static IEnumerable<TResult> xSelect<Tsource, TResult>(this IEnumerable<Tsource> source, Func<Tsource, TResult> selector)
        {
            foreach (Tsource item in source)
            {
                yield return selector(item);
            }
        }



        //public static IEnumerable<Tresult> xWhere<Tsource, Tresult>(this IEnumerable<Tsource> source, Func<)
    }

}




