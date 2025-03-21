using System;
using System.Collections.Generic;
using System.Data;

namespace forPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            //For example, given N = 1041 the function should return 5, 
            //because N has binary representation 10000010001 and so its longest binary gap is of length 5.
            BinaryGap binaryGap = new BinaryGap(1041);
            Console.WriteLine($"Binary Gap Result: {binaryGap.Solution()} in Total.");

            //trying to edit
            //trying to edit
            //trying to edit

            //CyclicRotation - Rotate an array to the right by a given number of steps.
            CyclicRotation rotateArrayPosition = new CyclicRotation();
            rotateArrayPosition.changePosition();

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
