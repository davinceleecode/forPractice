using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class Practice6
    {
        public string FrequentWord(string[] words)
        {
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!uniqueWords.TryAdd(word, 1))
                    uniqueWords[word] += 1;
            }


            int maxFreq = uniqueWords.Values.Max();


            var result = uniqueWords
                .Where(x => x.Value == maxFreq)
                .Select(x => x.Key)
                .First();

            var resultword = uniqueWords
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .First();

            return string.Empty;
        }
    }
}
