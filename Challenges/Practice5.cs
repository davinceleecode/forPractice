using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class Practice5
    {
        public int solution(int[] A)
        {

            /*----------------------------------------------------------------------------------*/
            //score: 50% only
            /*----------------------------------------------------------------------------------*/
            //int[] sortedItems = A.OrderBy(x => x).ToArray();
            //int missingNum = 0;
            //for (int i = 0; i < sortedItems.Length; i++)
            //{
            //    if (sortedItems[i] != i + 1)
            //    {
            //        missingNum = i + 1;
            //        break;

            //    }
            //}
            //return missingNum;


            /*----------------------------------------------------------------------------------*/
            //score: 80% only
            /*----------------------------------------------------------------------------------*/

            long TotalSumOfAllItems = (A.Length + 1) * (A.Length + 2) / 2;
            long MissingSumofAllItems = A.Sum(x => (long)x);


            return (int)(TotalSumOfAllItems - MissingSumofAllItems);
        }
    }
}
