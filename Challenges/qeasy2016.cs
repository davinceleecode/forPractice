using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy2016
    {
        public int MaximumDifference(int[] nums)
        {

            // 7,1,5,4
            // 1, 5, 2, 10
            int firstmin = nums[0], ans = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (firstmin < nums[i])
                    ans = Math.Max(ans, nums[i] - firstmin);
                else
                    firstmin = nums[i];
            }

            return ans;
        }
    }
}
