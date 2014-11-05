using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        int headSum = A[0];
        int tailSum = 0;
        //We first have to populate the sums so that we can add to          
	//the head and decrease from the tail one element at a time
        for (int i = 1; i < A.Length; i++) 
        {
            tailSum += A[i];
        }
        
        //Add to the head and decrease from the tail one element           
	//at a time
        const int MAX_INT = 2147483647;
        int lowestDifference = MAX_INT;
        for (int i = 1; i < A.Length; i++)
        {
            int difference = Math.Abs(headSum - tailSum); 
            if (difference < lowestDifference)
            {
                lowestDifference = difference;
            }
            headSum += A[i];
            tailSum -= A[i]; 
        }
        
        return lowestDifference;
    }
}
