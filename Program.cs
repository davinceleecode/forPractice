
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using forPractice.Challenges;

namespace forPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            Practice4 practice4 = new Practice4();
            practice4.solution(10, 85, 30);

            Practice3 practice3 = new Practice3();
            practice3.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 });

            Practice2 practice2 = new Practice2();
            practice2.solution(new int[] { 3, 8, 9, 7, 6 }, 3);

            Practice1 practice1 = new Practice1();
            practice1.Solution(529);

            qeasy3136 qeasy3136 = new qeasy3136();
            qeasy3136.IsValid("IS");

            qmedium1353 qmedium1353 = new qmedium1353();
            qmedium1353.MaxEvents(new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 }
            });

            qeasy3304 qeasy3304 = new qeasy3304();
            qeasy3304.KthCharacter(5);

            qeasy3330 qeasy3330 = new qeasy3330();
            qeasy3330.PossibleStringCount("abbcccc");

            qmedium2294 qmedium2294 = new qmedium2294();
            qmedium2294.PartitionArray(new int[] { 3, 6, 1, 2, 5 }, 2);


            qeasy2016 qeasy2016 = new qeasy2016();
            qeasy2016.MaximumDifference(new int[] { 1, 5, 2, 10 });

            qeasy3423 qeasy3423 = new qeasy3423();
            qeasy3423.MaxAdjacentDistance(new int[] { 1, 2, 4 });

            qhard3445 qhard3445 = new qhard3445();
            qhard3445.MaxDifference("12233", 4);

            qeasy3442 qeasy3442 = new qeasy3442();
            qeasy3442.MaxDifference("aaaaabbc");

            qmedium2434 qmedium2434 = new qmedium2434();
            qmedium2434.RobotWithString("bac");

            qmedium3403 qmedium3403 = new qmedium3403();
            qmedium3403.AnswerString("gggg", 2);

            qmedium2929 qmedium = new qmedium2929();
            qmedium.DistributeCandies(5, 2);


            qeasy2894 qeasy2894 = new qeasy2894();
            qeasy2894.DifferenceOfSums(5, 6);

            qmedium2131 qmedium2131 = new qmedium2131();
            qmedium2131.LongestPalindrome(new string[] { "lc", "cl", "gg", "cl", "gg", "gg" });

            contest contest = new contest();
            contest.MinCuttingCost(6, 5, 5);


            qeasy2942 qeasy2942 = new qeasy2942();
            qeasy2942.FindWordsContaining(new string[] { "leet", "code" }, 'E');


            qmedium3362 qmedium3362 = new qmedium3362();
            qmedium3362.MaxRemoval(new int[] { 1, 1, 1, 1 }, new int[][]
            {
                new int[] {1, 3},
                new int[] {0, 2},
                new int[] {1, 3},
                new int[] {1, 2}
            });

            qmedium3355 qmedium3355 = new qmedium3355();
            qmedium3355.IsZeroArray(new int[] { 1, 2, 1, 0, 0, 0 }, new int[][] { new int[] { 0, 3 }, new int[] { 2, 4 } });

            MutualFriends mutual = new MutualFriends();
            mutual.getCount(new List<int> { 2, 1, 1 });

            qhard1931 qhard1931 = new qhard1931();
            qhard1931.ColorTheGrid(2, 2);

            qmedium75 qmedium75 = new qmedium75();
            qmedium75.sortColors(new int[] { 2, 0, 2, 1, 1, 0 });

            var words = new string[] { "a", "b", "c", "d" };
            var group = new int[] { 1, 1, 0, 1 };
            qeasy2900 qeasy = new qeasy2900();
            Console.WriteLine(qeasy.GetLongestSubsequence(words, group));

            qhard3337_part_2 qhard3337 = new qhard3337_part_2();
            qhard3337.LengthAfterTransformations("abkz", 1, new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 });

            TotalCharInStringAfterTransformation totalCharInStringAfterTransformation = new TotalCharInStringAfterTransformation();
            Console.WriteLine(totalCharInStringAfterTransformation.LengthAfterTransformations("jqktcurgdvlibczdsvnsg", 7517));

            exam1 x = new exam1();
            Console.WriteLine(x.solution("126138944"));


            demo d = new demo();
            Console.WriteLine(d.solution(new[] { 1, 3, 6, 4, 1, 2 }));

            //Three concecutive odds
            ThreeConsecutiveOdds threeConsecutiveOdds = new ThreeConsecutiveOdds();
            Console.WriteLine(threeConsecutiveOdds.ThreeOdds(new int[] { 1, 2, 1, 1 }));

            //finding 3-digit even numbers
            Finding3DigitEvenNumbers finding3DigitEvenNumbers = new Finding3DigitEvenNumbers();
            var res = finding3DigitEvenNumbers.FindEvenNum(new int[] { 2, 1, 3, 0 });
            Console.WriteLine(res == null || res.Length == 0 ? "No even integers can be formed using the given digits." : string.Join(", ", res));

            //remove duplicate from sorted array
            Console.WriteLine(RemoveDuplicatesFromSortedArray.removeDuplicate(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }).ToString());

            List<long> arr = Console.ReadLine().TrimEnd()
                .Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt64(arrTemp))
                .ToList();

            //mini-max-sum
            MiniMaxSum miniMaxSum = new MiniMaxSum(arr);
            Console.WriteLine(string.Join(" ", miniMaxSum.Result().Select(r => r)));

            //plusminus | -4 3 -9 0 4 1 | expected output: 0.500000, 0.333333, 0.166667
            PlusMinus plusMinus = new PlusMinus(arr);
            Console.WriteLine(string.Join(", ", plusMinus.plusMinus().Select(pm => pm)));



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
