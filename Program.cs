
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace forPractice
{
    class Program
    {

        static void Main(string[] args)
        {

            //using custom linq extensions
            List<employee> employees = new List<employee>() {
                new employee{ Id = 1, Name = "Vincent"},
                new employee{ Id = 2, Name = "Lee"},
                new employee{ Id = 3, Name = "Flores"},
                new employee{ Id = 4, Name = "Via"}

            };

            var original = employees.xSelect(m => new { m.Name, m.Id }).ToList();
            var originalx = employees.Select(delegate (employee m)
            {
                return new { m.Id, m.Name, Message = "Done" };
            });

            var resultx = employees.Where(c => c.Id == 1).customSelect(c => c.Name);

            //########################################################################################
            //it doesn’t fully iterate twice due to lazy evaluation and how LINQ works. | put in debug mode to see what happen
            MyNumbers myNumbers = new MyNumbers();
            var evenNumbers = myNumbers
                .Where(n => n % 2 == 0) // First step: Filters elements
                .Select(n => $"Even: {n}")// Second step: Transforms elements
                .ToList();// Executes everything and stores the result


            //how iteration happen inside linq
            var resultnum = myNumbers
                .Where(n =>
                {
                    Console.WriteLine($"Checking: {n}");
                    return n % 2 == 0;
                })
                .Select(n =>
                {
                    Console.WriteLine($"Transforming: {n}");
                    return $"Even Number:{n}";
                })
                .ToList();
            //########################################################################################



            StudySelect studySelect = new StudySelect();
            studySelect.Trigger();


            //how yield works
            yieldList yieldList = new yieldList();
            yieldList.hitMe();


            //For example, given N = 1041 the function should return 5, 
            //because N has binary representation 10000010001 and so its longest binary gap is of length 5.
            BinaryGap binaryGap = new BinaryGap(1041);
            Console.WriteLine($"Binary Gap Result: {binaryGap.Solution()} in Total.");


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

            Console.WriteLine($"Working ondev updates");
            Console.WriteLine($"working in main updates");

        }

    }

}