﻿using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3423
    {
        public int MaxAdjacentDistance(int[] nums)
        {
            int n = nums.Length;
            int res = Math.Abs(nums[0] - nums[n - 1]);
            for (int i = 0; i < n - 1; ++i)
            {
                res = Math.Max(res, Math.Abs(nums[i] - nums[i + 1]));
            }
            return res;
            //comment a code Fixes #13
            //comment a code Fixes #15
            //comment a code Fixes #17
            //comment a code Fixes #20
            //comment a code Fixes #22
            //comment a code Fixes #22
            //comment a code Fixes #27

        }
    }
}

