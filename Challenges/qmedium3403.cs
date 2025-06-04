using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium3403
    {
        public string AnswerString(string word, int numFriends)
        {
            List<string> box = new List<string>();
            GenerateSplits(word, numFriends, 0, new List<string>(), box);
            return box.Max();
        }


        private void GenerateSplits(string word, int numParts, int start, List<string> currentParts, List<string> box)
        {
            if (currentParts.Count == numParts)
            {
                if (start == word.Length)
                {
                    box.AddRange(currentParts); // Add all parts to the box
                }
                return;


                for (int i = start + 1; i <= word.Length - (numParts - currentParts.Count) + 1; i++)
                {
                    string part = word.Substring(start, i - start);
                    currentParts.Add(part);
                    GenerateSplits(word, numParts, i, currentParts, box);
                    currentParts.RemoveAt(currentParts.Count - 1);
                }
            }
        }
    }
