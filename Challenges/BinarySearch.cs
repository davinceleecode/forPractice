﻿using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class BinarySearch
    {
        public int BinSearch(int[] arr, int target)
        {

            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
