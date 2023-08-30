using System;

public class Solution {
    public int solution(int n)
    {
        int answer = 0;
        int temp = 1;
        
        for(int i = 1; i <= 11; i++)
        {
            temp *= i;
            if(temp > n)
            {
                answer = i-1;
                break;
            }
        }
        return answer;
    }
}