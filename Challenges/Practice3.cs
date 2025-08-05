using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class Practice3
    {
        public int solution(int[] A)
        {
            /*----------------------------------------------------------------------------------*/
            //score: 66% only
            /*----------------------------------------------------------------------------------*/
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();


            foreach (int item in A)
            {
                if (keyValuePairs.ContainsKey(item))
                    keyValuePairs[item]++;
                else
                    keyValuePairs.Add(item, 1);
            }


            var unpairedItem = keyValuePairs
                                .Where(kv => kv.Value == 1)
                                .Select(kv => kv.Key)
                                .FirstOrDefault();

            return unpairedItem;


            /*----------------------------------------------------------------------------------*/
            //score: 55% only
            /*----------------------------------------------------------------------------------*/
            //var onlyUnique = A.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).ToArray();
            //return onlyUnique[0];

            /*----------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------------------*/



        }
    }
}
