using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int result = 0;
        int arrLength = A.Length;

        for (int i = 0; i < arrLength; i++)
        {
            for (int count = 0; i + 2 < arrLength && A[i + 1] - A[i] == A[i + 2] - A[i + 1]; i++)
            {
                count++;
                result += count;
            }
        }

        return result > 1000000000 ? -1 : result;
    }
}
