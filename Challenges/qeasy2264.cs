using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace forPractice.Challenges
{
    public class qeasy2264
    {
        public string LargestGoodInteger(string num)
        {
            //4ms
            string output = "";
            int ans = 0;
            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] == num[i + 1] && num[i + 1] == num[i + 2])
                {

                    output = Math.Max(ans, int.Parse(num.Substring(i, 3))) == 0 ? "000" : Math.Max(ans, int.Parse(num.Substring(i, 3))).ToString();
                    ans = int.Parse(output);

                }

                if (i == num.Length - 3)
                    break;
            }

            return output;


            //15ms
            //string pattern = @"(.)\1{2}";
            //MatchCollection matches = Regex.Matches(num, pattern);
            //return matches.Count > 0 ? matches.OrderByDescending(x => x.Value).FirstOrDefault().ToString() : string.Empty;

        }
    }
}
