using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class selectionSort
    {
        public int[] SelectionSortArr(int[] arr)
        {
            //comparing the value
            //4, 3, 5, 1, 2, 7, 6

            for (int i = 0; i < arr.Length; i++)
            {
                int currValue = arr[i];
                int swapIndex = i;

                for (int x = i + 1; x < arr.Length; x++) //start from i+1
                {
                    if (arr[swapIndex] > arr[x]) //find the smallest
                    {
                        swapIndex = x;
                    }

                }


                //swap once per outer loop
                arr[i] = arr[swapIndex];
                arr[swapIndex] = currValue;

            }




            return arr;






        }
    }
}
