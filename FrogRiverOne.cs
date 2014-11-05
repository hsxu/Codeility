using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int X, int[] A) 
    {
        HashSet<int> leafSet = new HashSet<int>();
        int jumpIndex = 1;
        
        for (int i = 0; i < A.Length; i++) 
        {
            leafSet.Add(A[i]);
            while (leafSet.Contains(jumpIndex))
            {
                jumpIndex++;
            }
            
            if (jumpIndex == X + 1)
            {
                return i;
            }
        }  
        return -1;
    }
}
