using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy3442
    {
        public int MaxDifference(string s)
        {
            int solution = 2;
            switch (solution)
            {
                case 1:
                    {
                        return SolutionPhase1(s);
                    }
                case 2:
                    {
                        return SolutionPhase2(s);
                    }
                default:
                    {
                        return 0;
                    }
            }

        }

        private int SolutionPhase1(string s)
        {
            // a1 - a2

            int oddCount = 0, evenCount = 0, count = 0;
            char currentChar = s.OrderBy(x => x).FirstOrDefault();

            // aaaaabbcaa
            // aaabbbcc
            // mmmmssy

            foreach (char item in s.OrderBy(x => x))
            {


                if (currentChar != item)
                {
                    if (count % 2 == 0)
                    {

                        evenCount = evenCount == 0 ? evenCount = count : Math.Min(evenCount, count); //evenCount < count ? evenCount : count;
                        count = 1;
                        currentChar = item;
                        continue;
                    }
                    else
                    {
                        oddCount = Math.Max(oddCount, count); //oddCount > count ? oddCount : count;
                        count = 1;
                        currentChar = item;
                        continue;
                    }
                }

                count++;
            }

            if (count > 1 && count % 2 == 0)
                evenCount = evenCount == 0 ? evenCount = count : evenCount < count ? evenCount : count;
            else
                oddCount = oddCount > count ? oddCount : count;


            var result = oddCount - evenCount;

            return result;
        }
        private int SolutionPhase2(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            // aaaaabbcaa 
            foreach (var c in s)
            {
                if (d.ContainsKey(c))
                    d[c]++;
                else
                    d[c] = 1;
            }

            int minEven = s.Length, maxOdd = 1;
            foreach (var kvp in d)
            {
                if (kvp.Value % 2 == 0)
                    minEven = Math.Min(minEven, kvp.Value);
                else
                    maxOdd = Math.Max(maxOdd, kvp.Value);
            }

            return maxOdd - minEven;
        }
    }
}
