using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3304
    {
        public char KthCharacter(int k)
        {
            StringBuilder sb = new StringBuilder("a");

            while (sb.Length < k)
            {
                StringBuilder next = new StringBuilder();
                for (int i = 0; i < sb.Length; i++)
                {
                    char c = sb[i];

                    char nextChar = (char)((c - 'a' + 1) % 26 + 'a');
                    next.Append(nextChar);
                }
                sb.Append(next);
            }
            return sb[k - 1];
        }
    }
}
