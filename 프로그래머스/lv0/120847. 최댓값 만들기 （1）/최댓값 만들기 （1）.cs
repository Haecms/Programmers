using System;

public class Solution {
    public int solution(int[] numbers)
    {
        int Max = 0;
        for(int i=0; i<numbers.Length; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                if(numbers[i]*numbers[j]>=Max)
                {
                    Max = numbers[i]*numbers[j];
                }
            }
        }
        int answer = Max;
        return answer;
    }
}