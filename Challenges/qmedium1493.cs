using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qmedium1493
    {
        public int LongestSubarray(int[] nums)
        {
            int result = 0;
            int counter = 0;

            List<int> listTable = new List<int>();

            //0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1
            //1, 1, 0, 1

            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] == 1)
                {
                    counter++;
                }
                else
                {
                    listTable.Add(counter);
                    listTable.Add(0);
                    counter = 0;
                    continue;
                }
            }


            if (counter > 0)
                listTable.Add(counter);



            int tableCount = listTable.Count;
            if (tableCount > 2)
            {
                for (int i = 1; i < tableCount; i++)
                {
                    result = Math.Max(result, listTable[i - 1] + listTable[i + 1]);
                    if (i + 1 == tableCount - 1)
                        break;
                }
            }
            else if (tableCount == 2)
            {
                result = Math.Max(listTable[0], listTable[1]);
            }
            else if (tableCount == 1)
            {
                result = listTable[0] > 0 ? listTable[0] - 1 : listTable[0];
            }

            return result;
        }
    }
}
