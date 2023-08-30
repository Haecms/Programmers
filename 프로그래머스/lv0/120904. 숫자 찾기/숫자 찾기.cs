using System;

public class Solution {
    public int solution(int a, int k)
    {
            int answer = -1;
            int a_a = (int)Math.Log10(a) + 1;
            int[] ints = new int[a_a];
            
            for(int i=0; i < a_a; i++)
            {
                ints[i] = a % 10;
                a /= 10;
            }
            Array.Reverse(ints);
            for(int i=0; i<a_a; i++)
            {
                if (ints[i] % 10 == k)
                {
                    answer = i+1;
                    break;
                }
                
            }
        return answer;
    }
}