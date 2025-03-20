using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace forPractice
{
    public class BinaryGap
    {
        private readonly int _num;
        public BinaryGap(int num)
        {
            _num = num;
        }

        public class numList
        {
            public int id { get; set; }
            public int numValue { get; set; }
        }


        public int Solution()
        {

            /*
             For example, given N = 1041 the function should return 5, 
             because N has binary representation 10000010001 and so its longest binary gap is of length 5. 

             Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

            The number 15 has binary representation 1111 and has no binary gaps. 
            The number 32 has binary representation 100000 and has no binary gaps.
             */

            //10000010001


            List<numList> _numLists = new List<numList>();
            bool isFound = false;
            int rowcount = 1;
            int zeroCount = 0;


            //10000
            //1000000000000010000000000000000010000000000000000000000000000000000001
            //11111111
            //string binaryValue = "1111101101";

            string binaryValue = Convert.ToString(_num, 2);
            for (int i = 0; i < binaryValue.Length; i++)
            {
                if (binaryValue[i].ToString() == "1" && isFound == false)
                {
                    isFound = true;
                    continue;
                }


                if (isFound)
                {
                    if (binaryValue[i].ToString() == "0")
                    {
                        zeroCount++;
                        continue;
                    }

                    if (binaryValue[i].ToString() == "1")
                    {
                        _numLists.Add(new numList { id = rowcount++, numValue = zeroCount });
                        zeroCount = 0;
                    }
                }
            }

            var maxitem = _numLists.OrderByDescending(n => n.numValue).FirstOrDefault();

            return (maxitem != null ? maxitem.numValue : 0);
        }

    }
}
