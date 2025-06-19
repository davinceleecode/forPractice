using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium2294
    {
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var count = 1;
            var start = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - start > k)
                {
                    count++;
                    start = nums[i];
                }
            }

            return count;
        }
    }
}
