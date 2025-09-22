using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy3005
    {
        public int MaxFrequency(int[] nums)
        {
            var result = nums
     .GroupBy(x => x)
     .Select(x => new
     {
         Value = x.Key,
         Total = x.Count()
     });

            int maxFreq = result.Max(x => x.Total);
            int total = result.Where(x => x.Total == maxFreq)
                              .Sum(x => x.Total);

            return total;

        }
    }
}
