using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public class yieldList
    {

        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Adding {i} to the list...");
                numbers.Add(i);

            }
            return numbers; // Returns all numbers at once
        }

        public static IEnumerable<int> GetNumbersWithYield()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Returning {i}...");
                yield return i;  // Returns one number at a time}

            }
        }


        public void hitMe()
        {
            //Code Example: Without yield (List)
            foreach (var num in GetNumbers())
            {
                Console.WriteLine($"Processing: {num}");
                if (num == 2) break; //stop early
            }

            //Code Example: With yield (Lazy Execution)

            foreach (var num in GetNumbersWithYield())
            {
                Console.WriteLine($"Processing: {num}");
                if (num == 2) break;  // Stop early
            }
        }

    }
}
