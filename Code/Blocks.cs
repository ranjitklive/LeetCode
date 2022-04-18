using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] blocks)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        int answer = 0;

        if (blocks != null && blocks.Length > 0)
        {
            int numOfBlocks = blocks.Length;
            int[] moveLeft = new int[numOfBlocks];
            int[] moveRight = new int[numOfBlocks];

            //movement to left not possible
            moveLeft[0] = 0;

            for (int i = 1; i < numOfBlocks; i++)
            {
                if (blocks[i] <= blocks[i - 1])
                {
                    //movement to left possible
                    moveLeft[i] = moveLeft[i - 1] + 1;
                }
                else
                {
                    //movement to left not possible
                    moveLeft[i] = 0;
                }
            }

            //movement to right not possible
            moveRight[numOfBlocks - 1] = 0;

            for (int i = numOfBlocks - 2; i >= 0; i--)
            {
                if (blocks[i] <= blocks[i + 1])
                {
                    //movement to right possible
                    moveRight[i] = moveRight[i + 1] + 1;
                }
                else
                {
                    //movement to right not possible
                    moveRight[i] = 0;
                }
            }

            int maxDistance = 0;
            for (int i = 0; i < numOfBlocks; i++)
            {
                if ((moveLeft[i] + moveRight[i] + 1) > maxDistance)
                {
                    maxDistance = moveLeft[i] + moveRight[i] + 1;
                }
            }
            answer = maxDistance;
        }


        return answer;

    }
}
