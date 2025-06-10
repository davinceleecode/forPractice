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

            // a1 - a2

            int oddCount = 0;
            int evenCount = 0;
            int count = 0;
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
                        evenCount = evenCount > count ? evenCount : count;
                        count = 1;
                        currentChar = item;
                        continue;
                    }
                    else
                    {
                        oddCount = oddCount > count ? oddCount : count;
                        count = 1;
                        currentChar = item;
                        continue;
                    }
                }

                count++;
            }

            if (count > 1 && count % 2 == 0)
                evenCount = evenCount > count ? evenCount : count;
            else
                oddCount = oddCount > count ? oddCount : count;


            var result = oddCount - evenCount;

            return result;
        }
    }
}
