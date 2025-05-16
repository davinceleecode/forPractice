using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace forPractice.Challenges
{
    public class qhard3337_part_2
    {
        const int MOD = 1_000_000_007;
        public int LengthAfterTransformations(string s, int t, IList<int> nums)
        {

            // Step 1: Build initial frequency vector
            long[] freq = new long[26];
            foreach (char c in s.ToLowerInvariant())
            {
                freq[c - 'a']++;
            }

            // Step 2: Build transformation matrix (26 x 26)
            long[,] matrix = new long[26, 26];
            for (int i = 0; i < 26; i++)
            {
                int idx = (i + 1) % 26;
                for (int j = 0; j < nums[i]; j++)
                {
                    matrix[i, idx] = (matrix[i, idx] + 1) % MOD;
                    idx = (idx + 1) % 26;
                }
            }

            // Step 3: Raise matrix to power t
            long[,] resultMatrix = MatrixPower(matrix, t);

            // Step 4: Multiply final matrix with freq vector
            long[] finalFreq = new long[26];
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    finalFreq[i] = (finalFreq[i] + resultMatrix[j, i] * freq[j]) % MOD;
                }
            }

            return (int)(finalFreq.Sum() % MOD);
        }

        private long[,] MatrixMultiply(long[,] A, long[,] B)
        {
            int size = 26;
            long[,] result = new long[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < size; k++)
                        result[i, j] = (result[i, j] + A[i, k] * B[k, j]) % MOD;
            return result;
        }

        private long[,] MatrixPower(long[,] matrix, int power)
        {
            int size = 26;
            long[,] result = new long[size, size];

            // Identity matrix
            for (int i = 0; i < size; i++)
                result[i, i] = 1;

            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    result = MatrixMultiply(result, matrix);
                }
                matrix = MatrixMultiply(matrix, matrix);
                power >>= 1;
            }

            return result;

        }
    }
}
