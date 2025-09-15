using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy1935
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {

            string[] words = text.ToLowerInvariant().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int brokenWords = 0;
            bool isBrokenLetter = false;

            foreach (string word in words)
            {
                foreach (char brokenLetter in brokenLetters.ToLowerInvariant())
                {
                    if (word.Contains(brokenLetter))
                        isBrokenLetter = true;

                }

                if (isBrokenLetter)
                {
                    isBrokenLetter = false;
                    brokenWords++;
                }
            }

            return words.Length - brokenWords;
        }
    }
}
