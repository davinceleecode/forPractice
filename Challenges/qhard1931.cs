using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qhard1931
    {
        const int MOD = 1_000_000_007;
        public int ColorTheGrid(int m, int n)
        {
            /* -----------------------------------------------------------
             * 1.  Enumerate every legal single‑column pattern.
             *     Store each pattern as an int where every 2 bits = 1 cell
             *     (≤ 5 rows → ≤ 10 bits).  List index (0…S‑1) is our DP key.
             * ----------------------------------------------------------- */
            var patterns = new List<int>();

            void Dfs(int row, int prevColor, int mask)
            {
                if (row == m)
                {
                    patterns.Add(mask);
                    return;
                }
                for (int color = 0; color < 3; ++color)
                {
                    if (color == prevColor) continue;               // vertical clash
                    int nextMask = mask | (color << (row * 2));     // pack 2 bits
                    Dfs(row + 1, color, nextMask);
                }
            }
            Dfs(0, -1, 0);
            int S = patterns.Count;                                 // ≤ 180

            /* -----------------------------------------------------------
             * 2.  Pre‑compute column compatibility (horizontal rule).
             * ----------------------------------------------------------- */
            var compat = new List<int>[S];
            for (int i = 0; i < S; ++i) compat[i] = new List<int>();

            for (int i = 0; i < S; ++i)
            {
                for (int j = 0; j < S; ++j)
                {
                    bool ok = true;
                    int a = patterns[i], b = patterns[j];
                    for (int r = 0; r < m && ok; ++r)
                    {
                        int ca = (a >> (r * 2)) & 3;
                        int cb = (b >> (r * 2)) & 3;
                        if (ca == cb) ok = false;                   // horizontal clash
                    }
                    if (ok) compat[i].Add(j);
                }
            }

            /* -----------------------------------------------------------
             * 3.  DP over columns.
             * ----------------------------------------------------------- */
            var dpPrev = new int[S];
            for (int i = 0; i < S; ++i)
                dpPrev[i] = 1;                                      // first column

            for (int col = 1; col < n; ++col)
            {
                var dpCur = new int[S];
                for (int i = 0; i < S; ++i)
                {
                    int ways = dpPrev[i];
                    if (ways == 0) continue;
                    foreach (int j in compat[i])
                    {
                        dpCur[j] = (dpCur[j] + ways) % MOD;
                    }
                }
                dpPrev = dpCur;                                     // slide window
            }

            /* -----------------------------------------------------------
             * 4.  Sum ways in the last column.
             * ----------------------------------------------------------- */
            long ans = 0;
            for (int i = 0; i < S; ++i)
            {
                ans += dpPrev[i];
                if (ans >= MOD) ans -= MOD;
            }
            return (int)ans;
        }
    }
}
