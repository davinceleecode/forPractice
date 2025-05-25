using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class contest
    {
        public long MinCuttingCost(int n, int m, int k)
        {
            /*
             2 logs 

             log 1 = 6(n)
             log 2 = 5(m)

             3 trucks trucks to be transported
                EACH truck carry 1 log length <= 5(k)

             Cutting log cost:
             log 2 = 5 so no need to cut

             log 1 = 6 
             possible cut
              1+5 -> cost = 1 * 5 = 5 (min)
              2+4 -> cost = 2 * 4 = 8
              3+3 -> cost = 3 * 3 = 9
              4+2 -> cost = 4 * 2 = 8
              5+1 -> cost = 5 * 1 = 5 (min)

              all cuts are valid (bot <= 5) now get the minimum cost
              5+1 or 1+5

             */
            return 0;
        }
    }
}
