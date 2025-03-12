using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public class UniqueFirstChar
    {
        public UniqueFirstChar()
        {

        }





        public char getUniqueFirstChar(string s)
        {
            #region 1st Option
            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (var c in s)
            {
                bool isFound = false;
                if (charCounter.ContainsKey(c))
                {
                    charCounter[c]++;
                    isFound = true;
                }

                if (!isFound)
                    charCounter[c] = 1;

            }

            foreach (var item in charCounter)
            {
                if (item.Value == 1)
                    return item.Key;
            }

            return '_';
            #endregion

            #region 2nd Option
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name", typeof(char));
            //dt.Columns.Add("Count", typeof(int));


            //foreach (var c in s)
            //{
            //    bool isFound = false;

            //    foreach (DataRow row in dt.Rows)
            //    {
            //        if ((char)row["Name"] == c)
            //        {
            //            row["Count"] = (int)row["Count"] + 1;
            //            isFound = true;
            //            break;
            //        }
            //    }

            //    if (!isFound)
            //        dt.Rows.Add(c, 1);
            //}

            //foreach (DataRow row1 in dt.Rows)
            //{
            //    if ((int)row1["Count"] == 1)
            //        return (char)row1["Name"];
            //}

            //return '_';
            #endregion
        }
    }
}
