using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy3541
    {
        public int MaxFreqSum(string s)
        {
            int[] vow = new int[26];
            int[] con = new int[26];
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in s)
            {
                if (vowels.Contains(c))
                    vow[c - 'a']++;
                else
                    con[c - 'a']++;
            }


            return vow.Max() + con.Max();
        }
    }
}
