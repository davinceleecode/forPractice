using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy1323
    {
        public int Maximum69Number(int num)
        {

            int max = 0;
            string nums = num.ToString();
            char[] chars = nums.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {

                if (chars[i] == '6')
                {
                    chars[i] = '9';
                }


                max = Math.Max(max, Convert.ToInt32(new string(chars)));

                chars = nums.ToCharArray();
            }

            return max;
        }
    }
}
