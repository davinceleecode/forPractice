using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class TotalCharInStringAfterTransformation
    {
        public int LengthAfterTransformations(string s, int t)
        {
            const int MOD = 1_000_000_007;
            //abcyy


            //z = ab
            //else: b=c c=d d=e

            long[] freq = new long[26];
            // create main table ref
            foreach (char item in s)
            {
                freq[item - 'a']++;
            }



            //loop tranformation count
            for (int a = 0; a < t; a++)
            {

                //create 2nd table ref new instance always
                long[] nextfreq = new long[26];

                //loop from main table ref
                for (int i = 0; i < freq.Length; i++)
                {

                    //z char logic here
                    if (i == 25)
                    {
                        //A
                        nextfreq[0] += freq[i] % MOD;
                        //B
                        nextfreq[1] += freq[i] % MOD;
                    }
                    else
                    {
                        //normal char logic here
                        if (freq[i] > 0)
                            nextfreq[i + 1] += freq[i] % MOD;
                    }

                    //pass  result to 2nd table ref

                }

                //main table ref = 2nd table ref
                freq = nextfreq;
            }

            //total sum count of char result
            long result = freq.Sum() % MOD;

            return (int)result;

        }
    }
}
