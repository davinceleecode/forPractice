using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class ThreeConsecutiveOdds
    {
        public bool ThreeOdds(int[] arr)
        {
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    oddCount++;
                else
                    oddCount = 0;

                if (oddCount == 3) break;
            }

            return oddCount == 3 ? true : false;
        }
    }
}
