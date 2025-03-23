using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace forPractice
{
    public class MyNumbers : IEnumerable<int>
    {

        private List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };


        public IEnumerator<int> GetEnumerator()
        {
            foreach (var number in numbers)
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
