using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy1317
    {
        public int[] GetNoZeroIntegers(int n)
        {
            int a = 0;
            int b = 0;
            for (int i = 1; i < n; i++)
            {
                a = i;
                b = n - i;

                if (!HasZero(a) && !HasZero(b))
                {
                    break;
                }

            }

            return new int[] { a, b };
        }

        private bool HasZero(int x)
        {

            while (x > 0)
            {
                if (x % 10 == 0) return true;
                x = x / 10;

            }

            return false;
        }
    }
}
