using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qhard3445
    {

        public int MaxDifference(string s, int k)
        {
            ReadOnlySpan<char> chars = "01234";
            int n = s.Length;
            int ans = int.MinValue;

            foreach (char a in chars)
            {
                foreach (char b in chars)
                {
                    if (a == b)
                        continue;

                    Span<int> best = stackalloc int[4];
                    best.Fill(int.MaxValue);

                    int cntA = 0, cntB = 0;
                    int prevA = 0, prevB = 0;
                    int left = -1;

                    for (int right = 0; right < n; right++)
                    {
                        if (s[right] == a) cntA++;
                        if (s[right] == b) cntB++;

                        while (right - left >= k && cntB - prevB >= 2)
                        {
                            int status = ((prevA & 1) << 1) | (prevB & 1);
                            best[status] = Math.Min(best[status], prevA - prevB);

                            left++;
                            if (s[left] == a) prevA++;
                            if (s[left] == b) prevB++;
                        }

                        int currentStatus = ((cntA & 1) << 1) | (cntB & 1);
                        int targetStatus = currentStatus ^ 0b10;
                        if (best[targetStatus] != int.MaxValue)
                        {
                            ans = Math.Max(ans, (cntA - cntB) - best[targetStatus]);
                        }
                    }
                }
            }

            return ans;
        }

    }
}
