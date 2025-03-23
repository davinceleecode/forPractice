using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice
{
    public static class TestExtension
    {
        public static IEnumerable<TResult> MyWhereSelect<Tsource, TResult>(
            this IEnumerable<Tsource> source,
            Func<Tsource, bool> predicate,
            Func<Tsource, TResult> selector)
        {
            List<TResult> result = new List<TResult>();
            foreach (Tsource item in source)
            {
                if (predicate(item))
                {
                    result.Add(selector(item));
                }

            }

            return result;
        }
        public static string myString(this string go)
        {
            return $"Hello: {go}";
        }

        public static IEnumerable<TResult> MySelect<Tsource, TResult>(
            this IEnumerable<Tsource> source,
            Func<Tsource, TResult> selector)
        {
            List<TResult> results = new List<TResult>();
            foreach (Tsource item in source)
            {
                TResult a = selector(item);
                results.Add(a);
            }

            return results;
        }
    }

    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StudySelect
    {
        public void Trigger()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<employee> employees = new List<employee>
            {
                new employee { Id = 1, Name = "Vincent"},
                new employee { Id = 2, Name = "Lee"},
                new employee { Id = 3, Name = "Flores"},

            };



            string a = "a".myString();

            //Where (filtering) and Select (transformation) 
            var x = numbers.MyWhereSelect(n => n % 2 == 0, n => $"Even Number: {n}");
            var y = employees.MySelect(e => e.Name);
            var z = employees.MyWhereSelect(e => e.Id == 2, e => $"The name I select: {e.Name}");



            Func<int, bool> isEven = num => num % 2 == 0;
            var resultLambda = numbers.Where(isEven);


            bool IsEvenn(int num)
            {
                return num % 2 == 0;
            }
            var resultRegMethod = numbers.Where(IsEvenn);


            var stringNumbers1 = numbers.Select(n => $"Number: {n}").ToList();
            var stringNumbers2 = numbers.Select(delegate (int m)
            {
                if (m == 5)
                    return $"numberXXXX: {m}";
                else
                    return $"number: {m}";
            }
            );

            var stringNumbers3 = numbers.Select(n =>
            {
                return $"Number: {n}";
            }).ToList();
        }
    }


}