using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        int expectedSum = 0;
        int actualSum = 0;
        
        for (int i = 0; i < A.Length; i++) 
        {
            expectedSum += (i+1);
            actualSum += A[i];
        }
        expectedSum += A.Length + 1;
        
        return expectedSum - actualSum;
    }
}
