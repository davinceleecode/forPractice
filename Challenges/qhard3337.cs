using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qhard3337
    {
        public int LengthAfterTransformations(string s, int t, IList<int> nums)
        {
            const int MOD = 1_000_000_007;

            long[] freq = new long[26];

            //1st table reference
            foreach (char item in s.ToLowerInvariant())
            {
                freq[item - 'a']++;
            }



            //number of transformation
            for (int a = 0; a < t; a++)

            {
                //2nd table result
                long[] freqNext = new long[26];


                //getting internalTransform value
                for (int b = 0; b < nums.Count; b++)
                {

                    //if only 1st table has value
                    if (freq[b] > 0)
                    {

                        //nums item values
                        int nextIndex = (b + 1) % 26;

                        for (int i = 0; i < nums[b]; i++)
                        {
                            freqNext[nextIndex] = (freqNext[nextIndex] + freq[b]) % MOD;
                            nextIndex = (nextIndex + 1) % 26;
                        }

                    }

                }

                freq = freqNext;

            }

            int result = (int)(freq.Sum() % MOD);

            return result;
        }
    }
}
