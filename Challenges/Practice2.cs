using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class Practice2
    {
        public int[] solution(int[] A, int K)
        {

            int TotalItemCount = A.Length;
            int[] B = new int[A.Length];



            /*  A = 3 8 9 7 6
                K = 3

                R = 9 7 6 3 8
            */

            for (int i = 0; i < TotalItemCount; i++)
            {
                B[(i + K) % TotalItemCount] = A[i];
            }

            return new int[] { };
        }
    }
}
