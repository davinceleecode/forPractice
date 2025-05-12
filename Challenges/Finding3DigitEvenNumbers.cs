using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class Finding3DigitEvenNumbers
    {
        public int[] FindEvenNum(int[] digits)
        {
            HashSet<int> uniqueNum = new HashSet<int>();

            //{ 2, 1, 3, 0 }
            //getting first digit ~ 2
            for (int a = 0; a < digits.Length; a++)
            {
                //bypass start with 0
                if (digits[a] == 0) continue;


                //getting second digit ~ 2 1
                for (int b = 0; b < digits.Length; b++)
                {
                    if (b != a)
                    {

                        //getting third digit ~ 2 1 3
                        for (int c = 0; c < digits.Length; c++)
                        {
                            if (c != a && c != b)
                            {

                                int num = int.Parse($"{digits[a]}{digits[b]}{digits[c]}");
                                if (num % 2 == 0)
                                {
                                    uniqueNum.Add(num);
                                    //Console.WriteLine($"{digits[a]} {digits[b]} {digits[c]}");
                                }

                            }


                        }
                    }
                }

            }
            return uniqueNum.OrderBy(x => x).ToArray();

        }
    }
}
