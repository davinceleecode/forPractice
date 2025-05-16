using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy2900
    {
        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {

            Dictionary<int, HashSet<string>> result = new Dictionary<int, HashSet<string>>();
            for (int i = 0; i < groups.Length; i++)
            {
                HashSet<string> unequal = new HashSet<string>();
                int lastnotequal = 0;
                for (int x = i; x < groups.Length; x++)
                {
                    if (groups[lastnotequal > 0 ? lastnotequal : i] != groups[x])
                    {
                        unequal.Add(words[i]);
                        unequal.Add(words[x]);
                        result[i] = unequal;
                        lastnotequal = x;
                    }

                }
            }

            if (!result.Any())
                return new List<string> { words[0] };

            int maxItem = result.Values.Max(x => x.Count);
            var maxSets = result.Values.Where(x => x.Count == maxItem);



            return maxSets.First().ToList();

        }
    }
}

