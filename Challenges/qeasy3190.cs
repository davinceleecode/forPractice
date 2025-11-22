using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3190
    {

        public int MinimumOperations(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += ((nums[i] + 1) % 3) == 0 ? 1 : ((nums[i] - 1) % 3) == 0 ? 1 : 0;
            }
            return result;
        }
    }
}
