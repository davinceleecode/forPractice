using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qmedium75
    {
        public void sortColors(int[] nums)
        {
            int numcount = nums.Length;
            if (numcount < 0 || numcount > 300)
                return;

            //[2,0,2,1,1,0]
            int red = 0; //0
            int white = 0; //1
            int blue = 0; //2

            for (int i = 0; i < numcount; i++)
            {

                switch (nums[i])
                {
                    case 0:
                        {
                            red++;
                            break;
                        }

                    case 1:
                        {
                            white++;
                            break;
                        }
                    case 2:
                        {
                            blue++;
                            break;
                        }
                }
            }

            int counter = 0;
            //red
            for (int i = 0; i < red; i++)
            {
                nums[counter] = 0;
                counter++;
            }

            //white
            for (int i = 0; i < white; i++)
            {
                nums[counter] = 1;
                counter++;
            }

            //blue
            for (int i = 0; i < blue; i++)
            {
                nums[counter] = 2;
                counter++;
            }



        }
    }
}
