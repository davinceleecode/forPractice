using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3330
    {
        public int PossibleStringCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[i + 1])
                {
                    count++;
                }
            }
            return count + 1;
        }
    }
}
