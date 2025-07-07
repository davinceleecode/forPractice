using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium1353
    {
        public int MaxEvents(int[][] events)
        {
            Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));
            int res = 0, i = 0, n = events.Length;
            var minHeap = new SortedSet<int>();
            int day = events[0][0];

            while (minHeap.Count > 0 || i < n)
            {
                // Add events starting today
                while (i < n && events[i][0] == day)
                {
                    minHeap.Add(events[i][1]);
                    i++;
                }

                // Attend the event with the earliest end time
                if (minHeap.Count > 0)
                {
                    minHeap.Remove(minHeap.Min);
                    res++;
                }

                day++;

                // Remove events that have already ended
                while (minHeap.Count > 0 && minHeap.Min < day)
                {
                    minHeap.Remove(minHeap.Min);
                }
            }

            return res;
        }
    }
}
