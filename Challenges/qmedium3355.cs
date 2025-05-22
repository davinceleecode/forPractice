using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qmedium3355
    {
        public bool IsZeroArray(int[] nums, int[][] queries)
        {
            int limit = 100_000;

            if (nums.Length > limit) return false;


            int[] diff = new int[nums.Length + 1];

            for (int i = 0; i < queries.Length; i++)
            {

                int start = queries[i][0];
                int end = queries[i][1];


                diff[start] -= 1;
                diff[end + 1] += 1;

            }

            int running = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                running += diff[i]; // -2
                nums[i] += running;
            }

            var result = nums.Any(x => x > 0) ? false : true;

            return result;
        }
    }
}
