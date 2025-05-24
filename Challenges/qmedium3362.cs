using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.Challenges
{
    public class qmedium3362
    {
        public int MaxRemoval(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int q = queries.Length;
            int[] coverage = new int[n];

            // Step 1: Count how many times each index is covered
            foreach (var query in queries)
            {
                int l = query[0];
                int r = query[1];
                coverage[l]++;
                if (r + 1 < n)
                    coverage[r + 1]--;
            }

            // Convert difference array to prefix sum
            for (int i = 1; i < n; i++)
                coverage[i] += coverage[i - 1];

            // Step 2: If any index is under-covered, return -1
            for (int i = 0; i < n; i++)
            {
                if (coverage[i] < nums[i])
                    return -1;
            }

            // Step 3: Greedy removal (try removing queries in reverse)
            // Initialize coverage again
            int[] currentCoverage = new int[n];
            foreach (var query in queries)
            {
                for (int i = query[0]; i <= query[1]; i++)
                    currentCoverage[i]++;
            }

            int removed = 0;

            for (int i = q - 1; i >= 0; i--)
            {
                var query = queries[i];
                bool canRemove = true;

                // Check if removing this query still satisfies nums
                for (int j = query[0]; j <= query[1]; j++)
                {
                    if (currentCoverage[j] - 1 < nums[j])
                    {
                        canRemove = false;
                        break;
                    }
                }

                if (canRemove)
                {
                    // Remove the query
                    removed++;
                    for (int j = query[0]; j <= query[1]; j++)
                        currentCoverage[j]--;
                }
            }

            return removed;
        }
    }
}
