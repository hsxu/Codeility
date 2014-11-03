using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        bool[] isIndexChecked = new bool[A.Length + 1];
        
        for (int i = 0; i < A.Length; i++)
        {
            //If the element is greater than the length, less than 1, or has 
            //already been seen, the array CANNOT be a permutation.
            if (A[i] > A.Length || A[i] < 1 || isIndexChecked[A[i]])
            {
                return 0;
            }
            
            if (!isIndexChecked[A[i]])
            {
                isIndexChecked[A[i]] = true;
            }
        } 
        return 1;
    }
}
