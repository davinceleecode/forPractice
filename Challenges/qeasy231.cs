using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy231
    {
        public bool isPowerOfTwo(int n)
        {

            if (n < 1) return false;
            if (n == 1 || n == 2) return true;
            if (n % 2 == 1) return false;


            int num = 2;
            while (num <= n)
            {
                if (num == n) return true;
                if (num > int.MaxValue / 2) break;

                num *= 2;
            }

            return false;
        }

    }
}
