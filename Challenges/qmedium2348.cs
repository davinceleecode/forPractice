using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium2348
    {

        public long ZeroFilledSubarray(int[] nums)
        {

            long continousZeroCount = 0;
            long output = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (continousZeroCount == 0 && nums[i] == 0)
                {
                    continousZeroCount++;
                    if (nums.Length - 1 == i)
                        output += ComputeAnswer(continousZeroCount);
                }


                else if (continousZeroCount > 0)
                {
                    if (IsContinousZero(nums[i]))
                    {
                        continousZeroCount++;

                        if (nums.Length - 1 == i)
                            output += ComputeAnswer(continousZeroCount);

                    }
                    else
                    {
                        output += ComputeAnswer(continousZeroCount);
                        continousZeroCount = 0;
                    }

                }

            }

            return output;
        }

        public long ComputeAnswer(long num)
        {
            return num * (num + 1) / 2;
        }

        public bool IsContinousZero(long count)
        {
            if (Math.Abs(count) > 0)
                return false;
            else
                return true;
        }
    }
}
