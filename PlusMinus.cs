using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace forPractice
{
    public class PlusMinus
    {
        List<int> arr = new List<int>();
        public PlusMinus(List<int> Arr)
        {
            arr = Arr;
        }
        public List<string> plusMinus()
        {
            double totalCount = arr.Count;

            double positiveNum = arr.Where(n => n > 0).Count() / totalCount;
            double negativeNum = arr.Where(n => n < 0).Count() / totalCount;
            double zeroNum = arr.Where(n => n == 0).Count() / totalCount;



            return new List<string> {
                positiveNum.ToString("F6"),
                negativeNum.ToString("F6"),
                zeroNum.ToString("F6")
            };
        }
    }
}
