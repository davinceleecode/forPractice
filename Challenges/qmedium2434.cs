using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium2434
    {
        public string RobotWithString(string s)
        {
            //bdda

            int lastIndex = s.Length;
            List<char> t = new List<char>();
            StringBuilder p = new StringBuilder();



            var chars = s.ToCharArray();
            char lastChar = new char();

            t.Add(chars[0]);
            for (int i = 1; i < chars.Length; i++)
            {

                if (chars.Length == i + 1)
                {
                    lastChar = chars[i];
                    break;
                }


                if (t[0] > chars[i])
                {
                    p.Append(chars[i]);
                }
                else
                {
                    t.Add(chars[i]);
                }
            }



            for (int i = 0; i < t.Count; i++)
            {



                if (t[i] > lastChar)
                    p.Append(t[i]);
            }



            return null;

        }
    }
}
