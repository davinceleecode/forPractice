using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    class qeasy2894
    {
        public int DifferenceOfSums(int n, int m)
        {

            int num1 = 0;
            int num2 = 0;
            int current = 1;


            for (int i = 0; i < n; i++)
            {

                if (current % m != 0)
                    num1 += current;
                else
                    num2 += current;

                current++;
            }


            int answer = num1 - num2;

            return answer;
        }
    }
}
