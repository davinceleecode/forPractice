using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy3000
    {
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {


            //1ms
            //int output = 0;
            //List<Rectangle> rectangles = new List<Rectangle>();

            //for (int i = 0; i < dimensions.Length; i++)
            //{
            //    double diagonalLength = Math.Sqrt(dimensions[i][0] * dimensions[i][0] + dimensions[i][1] * dimensions[i][1]);

            //    output = dimensions[i][0] * dimensions[i][1];

            //    rectangles.Add(new Rectangle { DiagonalLength = diagonalLength, Area = output });

            //}


            //var maxArea = rectangles
            //    .OrderByDescending(r => r.DiagonalLength)
            //    .ThenByDescending(r => r.Area)
            //    .First();

            //return maxArea.Area;


            //0 ms

            int maxArea = 0;
            double maxDiag = 0;

            for (int i = 0; i < dimensions.Length; i++)
            {
                var side1 = dimensions[i][0];
                var side2 = dimensions[i][1];

                var currDiag = Math.Sqrt(side1 * side1 + side2 * side2);
                var currArea = side1 * side2;


                if (currDiag > maxDiag)
                {
                    maxDiag = currDiag;
                    maxArea = currArea;
                }

                if (currDiag == maxDiag && currArea > maxArea)
                {
                    maxDiag = currDiag;
                    maxArea = currArea;
                }


            }
            return maxArea;
        }

        public class Rectangle
        {
            public double DiagonalLength { get; set; }
            public int Area { get; set; }
        }
    }
}
