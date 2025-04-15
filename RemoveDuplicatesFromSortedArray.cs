using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace forPractice
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int removeDuplicate(int[] nums)
        {
            // 0,0,1,1,1,2,2,3,3,4
            if (nums.Length == 0) return 0;

            int updateIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[updateIndex] = nums[i];
                    updateIndex++;
                }
            }
            return updateIndex;
        }
    }
}
