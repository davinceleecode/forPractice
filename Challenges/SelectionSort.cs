using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class selectionSort
    {
        public int[] SelectionSortArr(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {



                if (arr[i] < arr[i + 1])
                {
                    int item1 = arr[i];
                    int item2 = arr[i + 1];

                    arr[i] = item2;
                    arr[i + 1] = item1;
                }
            }

            return arr;

        }
    }
}
