using System;
using System.Collections.Generic;
using System.Data;

namespace forPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given a string, return the first non-repeating character. If all characters repeat, return '_'.
            UniqueFirstChar returnUniqueChar = new UniqueFirstChar();
            string input = "swiss";
            char result = returnUniqueChar.getUniqueFirstChar(input);


            //Write a C# function that removes duplicates from an array while maintaining the original order.
            int[] numbers = { 1, 2, 2, 3, 3, 5, 5, 6, 7, 8, 9 };
            RemoveDuplicateNum removeduplicatenum = new RemoveDuplicateNum(numbers);
            Console.WriteLine(String.Join(",", removeduplicatenum.RemoveDuplicates()));
        }

    }
}
