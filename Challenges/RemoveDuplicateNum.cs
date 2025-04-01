using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public class RemoveDuplicateNum
    {

        private int[] numbers;
        public RemoveDuplicateNum()
        {

        }
        public RemoveDuplicateNum(int[] number)
        {
            numbers = number;
        }


        //Write a C# function that removes duplicates from an array while maintaining the original order.
        public int[] RemoveDuplicates()
        {
            List<int> check = new List<int>();

            foreach (int num in this.numbers)
            {
                if (!check.Contains(num))
                {
                    check.Add(num);
                }
            }

            return check.ToArray();
        }
    }
}
