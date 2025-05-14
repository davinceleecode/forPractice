using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class demo
    {
        public int solution(int[] A)
        {
            

            var getMaxNum = A.Max(); 

            if (getMaxNum <= 0) return 1;

            var sortedA = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();

            int finalResult = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (sortedA[i] != finalResult)
                    return finalResult;

                finalResult++;
            }


           


            return finalResult;
        }
    }
}
