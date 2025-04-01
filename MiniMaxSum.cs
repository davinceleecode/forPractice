using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice
{
    public class MiniMaxSum
    {
        private List<long> arr;
        public MiniMaxSum(List<long> Arr)
        {
            arr = Arr;
        }

        public List<long> Result()
        {
            var maxList = arr.Where(x => x != arr.Max()).ToList();
            var minList = arr.Where(x => x != arr.Min()).ToList();

            var maxResult = maxList.Sum();
            var minResult = minList.Sum();

            if (maxResult == 0)
                maxResult = arr.Sum() - arr.FirstOrDefault();

            if (minResult == 0)
                minResult = arr.Sum() - arr.FirstOrDefault();



            return new List<long> { maxList.Sum(), minList.Sum() };
        }
    }
}
