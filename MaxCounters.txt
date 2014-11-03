using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int[] counters = new int[N];
        int maxCounter = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            //If the element is N+1, then all counters should be set to max counter.
            if (A[i] == N+1)
            {
                for (int j = 0; j < N; j++)
                {
                    counters[j] = maxCounter;
                }
            }
            
            //If the element is between 1 and N, then we should increment that counter.  
            else if (A[i] >= 1 || A[i] <= N)
            {
                counters[A[i] - 1]++;
                if (counters[A[i] - 1] > maxCounter)
                {
                    maxCounter = counters[A[i] - 1];
                }
            }
        }
        return counters;
    }
}
