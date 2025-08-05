using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy3477
    {

        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            //4, 2, 5  ||   3, 5, 4

            List<int> listofbaskets = new List<int>(baskets);

            for (int i = 0; i < fruits.Length; i++)
            {


                for (int x = 0; x < listofbaskets.Count; x++)
                {
                    if (listofbaskets[x] >= fruits[i])
                    {
                        listofbaskets.RemoveAt(x);
                        break;
                    }
                }
            }

            return listofbaskets.Count;
        }
    }
}
