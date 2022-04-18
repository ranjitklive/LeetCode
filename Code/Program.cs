using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public static class Program
    {
        public static void Main()
        {
            Solution s = new Solution();

            int sol = s.solution(new int[] { 1, 3, 4, 1 });

            Console.WriteLine(sol);
        }
    }

    public class Solution
    {
        public int solution(int[] A)
        {
            int returnVal = -1;

            if (A != null && A.Length <= 100000)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                List<int> numbers = new List<int>();

                for (int i = 0; i < A.Length; i++)
                {
                    numbers.Add(A[i]);
                }

                A = numbers.Distinct().OrderBy(t=>t).ToArray();

                for (int i = 0; i < A.Length; i++)
                {
                    if (i + 1 == A[i])
                    {
                        continue;
                    }
                    else
                    {
                        returnVal = i + 1;
                        break;
                    }
                }
            }

            return returnVal;
        }
    }
}
