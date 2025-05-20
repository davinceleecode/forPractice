using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class MutualFriends
    {
        public int getCount(List<int> A)
        {
            // 1 = 2
            // 2 = 1
            // 3 = 1
            int bestfriend = 0;
            int person = 0;
            int mutual = 0;




            Dictionary<int, int> persons = new Dictionary<int, int>();

            for (int i = 0; i < A.Count; i++)
            {
                persons.Add(i + 1, A[i]);
            }




            HashSet<int> visited = new HashSet<int>();
            for (int i = 0; i < persons.Count; i++)
            {
                person = persons.ElementAt(i).Key;
                mutual = persons.ElementAt(i).Value;

                if (person == mutual) continue;


                if (persons.ContainsKey(mutual) &&
                    persons[mutual] == person &&
                    !visited.Contains(person) &&
                    !visited.Contains(mutual))
                {
                    bestfriend++;
                    visited.Add(mutual);
                    visited.Add(person);
                }

            }



            return bestfriend;

        }
    }
}
