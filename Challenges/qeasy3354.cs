using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3354
    {
        public int CountValidSelections(int[] nums)
        {
            var totalSum = nums.Sum();
            var leftSide = 0;
            var result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    var rightSide = totalSum - leftSide;

                    if (leftSide == rightSide)
                        result += 2;
                    else if (Math.Abs(leftSide - rightSide) == 1)
                        result += 1;
                    else if (leftSide > rightSide)
                        break;
                }
                else
                    leftSide += nums[i];
            }

            return result;
        }
    }
}
