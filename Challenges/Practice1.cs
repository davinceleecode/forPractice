using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class Practice1
    {
        public int Solution(int N)
        {

            string binary = Convert.ToString(N, 2);
            int countGap = 0;
            int longestGap = 0;
            bool isValid = false;

            foreach (char item in binary)
            {
                if (item.ToString() == "1" && isValid == false)
                {
                    isValid = true;
                    continue;
                }
                else if (item.ToString() == "1")
                {
                    longestGap = Math.Max(longestGap, countGap);
                    countGap = 0;
                    continue;
                }
                countGap++;
            }
            return longestGap;
        }
    }
}
