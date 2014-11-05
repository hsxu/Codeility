using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        int numZeroes = 0;
        int numPassingCars = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
            {
                numZeroes++;
            }
            else if (A[i] == 1)
            {
                numPassingCars += numZeroes;
            }
        }   
        
        return (numPassingCars >= 0 && numPassingCars <= 1000000000) ? numPassingCars : -1;
    }
}
