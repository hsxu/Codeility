using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        HashSet<int> distinct = new HashSet<int>();
        int distinctCount = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (!distinct.Contains(A[i]))
            {
                distinct.Add(A[i]);
                distinctCount++;
            }            
        }
        return distinctCount;
    }    
}
