using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class Practice4
    {
        public int solution(int X, int Y, int D)
        {
            //10 85 30


            //55% score
            //if (X < 1 || Y < 1 || D < 1)
            //    return 0;
            //int totalJump = 0;
            //int numJump = X;
            //while (numJump < Y)
            //{
            //    numJump = numJump + D;
            //    totalJump++;
            //}


            //100% score
            if (X < 1 || Y < 1 || D < 1)
                return 0;

            int num = (Y - X) / D;
            int rem = (Y - X) % D;



            return rem > 0 ? num + 1 : num;
        }
    }
}
