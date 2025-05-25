using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    class qmedium2131
    {
        public int LongestPalindrome(string[] words)
        {

            var freq = new Dictionary<string, int>();
            int result = 0;
            bool hasCenter = false;

            foreach (var word in words)
            {
                if (freq.ContainsKey(word)) freq[word]++;
                else freq[word] = 1;
            }

            foreach (var word in freq.Keys)
            {
                string rev = new string(new char[] { word[1], word[0] });

                if (word == rev)
                {
                    // Word is a palindrome (like "gg", "aa")
                    int count = freq[word];
                    result += (count / 2) * 4;
                    if (count % 2 == 1) hasCenter = true;
                }
                else if (string.Compare(word, rev) < 0 && freq.ContainsKey(rev))
                {
                    // Pair word and its reverse once
                    result += Math.Min(freq[word], freq[rev]) * 4;
                }
            }

            if (hasCenter) result += 2;

            return result;
        }
    }
}
