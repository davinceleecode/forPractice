using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium1277
    {
        public int CountSquares(int[][] matrix)
        {


            #region Time Limit Exceeded | 22/32 testcases passed
            //int cols = matrix[0].Length;
            //int rows = matrix.Length;

            //int countOfIndividualSquare = 0;
            //bool IsIndividualCountDone = false;
            //int individualIndicatorCount = 0;


            ////identify max square
            //int maxSquare = Math.Min(cols, rows);
            //int countOfPerfectSquare = 0;
            //int isPerfectSquare = 1;


            //for (int numberOfSquare = 1; numberOfSquare <= maxSquare; numberOfSquare++)
            //{


            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int x = 0; x < matrix[i].Length; x++)
            //        {
            //            individualIndicatorCount++;
            //            if (!IsIndividualCountDone)
            //            {
            //                if (matrix[i][x] > 0)
            //                    countOfIndividualSquare++;

            //                if (cols * rows == individualIndicatorCount)
            //                    IsIndividualCountDone = true;
            //            }



            //            for (int r = 0; r < numberOfSquare; r++)
            //            {
            //                for (int c = 0; c < numberOfSquare; c++)
            //                {

            //                    Console.Write(matrix[i + r][x + c]);
            //                    isPerfectSquare = Math.Min(isPerfectSquare, matrix[i + r][x + c]);
            //                    if (isPerfectSquare == 0)
            //                        break;
            //                }
            //                Console.WriteLine(" ");

            //            }

            //            if (isPerfectSquare.Equals(1))
            //                countOfPerfectSquare++;

            //            isPerfectSquare = 1;

            //            Console.WriteLine("------");
            //            if (x == matrix[i].Length - numberOfSquare)
            //                break;

            //        }

            //        if (i == rows - numberOfSquare)
            //            break;

            //    }

            //}

            //return countOfIndividualSquare + (countOfPerfectSquare - countOfIndividualSquare);

            #endregion


            #region Accepted | Dynamic Programming Approach
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int total = 0;

            int[][] dp = new int[rows][];
            for (int i = 0; i < rows; i++)
                dp[i] = new int[cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {

                    Console.Write(matrix[r][c] + " ");

                    if (matrix[r][c] == 1)
                    {
                        if (r == 0 || c == 0)
                            dp[r][c] = 1;
                        else
                            dp[r][c] = 1 + Math.Min(dp[r - 1][c],
                                         Math.Min(dp[r][c - 1], dp[r - 1][c - 1]));

                        total += dp[r][c];
                    }
                }
                Console.WriteLine("\n-----");
            }

            return total;
            #endregion
        }




    }
}
