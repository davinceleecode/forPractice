using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qeasy3136
    {
        public bool IsValid(string word)
        {



            //It contains a minimum of 3 characters.
            if (word.Length < 3)
                return false;

            string vowel = "aeiouAEIOU";
            bool hasV = false, hasC = false;
            foreach (char w in word)
            {
                //It contains only digits(0 - 9), and English letters(uppercase and lowercase).
                if (!char.IsLetterOrDigit(w))
                {
                    return false;
                }
                else
                {
                    //It includes at least one vowel.
                    if (vowel.Contains(w))
                        hasV = true;

                    //It includes at least one consonant.
                    if (char.IsLetter(w) && !vowel.Contains(w))
                        hasC = true;

                }


            }


            return hasV && hasC;
        }
    }
}
