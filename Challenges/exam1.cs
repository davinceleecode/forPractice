using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class exam1
    {
        public int solution(string S)
        {

            //unique int
            HashSet<int> allNum = new HashSet<int>();

            int[] arr = new int[S.Length];
            int i = 0;
            foreach (var item in S)
            {
                arr[i] = int.Parse(item.ToString());
                i++;
            }

            // getting first num
            for (int a = 0; a < arr.Length; a++)
            {

                //getting second num
                for (int b = 0; b < arr.Length; b++)
                {
                    int num = int.Parse(arr[a].ToString() + arr[b].ToString());
                    if (num % 2 != 0)
                        allNum.Add(num);
                }
            }

            // 41, 13,83  41,

            return allNum.Count;



        }
    }
}
