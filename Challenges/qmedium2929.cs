using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium2929
    {
        public long DistributeCandies(int n, int limit)
        {

            string str = "ABC";

            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }








            long totalWays = 0;

            // Inclusion-Exclusion for 3 children (2^3 = 8 subsets)
            for (int mask = 0; mask < (1 << 3); mask++)
            {
                int sum = n;
                int sign = 1;

                for (int i = 0; i < 3; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        sum -= (limit + 1);
                        sign *= -1;
                    }
                }

                if (sum >= 0)
                {
                    totalWays += sign * Combination(sum + 2, 2); // C(sum + 2, 2)
                }
            }

            return totalWays;
        }
        private long Combination(long n, long k)
        {
            if (n < k || k < 0) return 0;

            long result = 1;
            for (long i = 1; i <= k; i++)
            {
                result = result * (n - i + 1) / i;
            }

            return result;
        }
    }
}

