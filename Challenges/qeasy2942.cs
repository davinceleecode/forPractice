using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qeasy2942
    {
        public List<int> FindWordsContaining(string[] words, char x)
        {

            if (words.Length <= 0 && words.Length > 50) return null;

            var convertChar = x.ToString().ToLowerInvariant();


            List<int> result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(convertChar))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
