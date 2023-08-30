using System;

public class Solution {
    public int solution(int[] array)
    {
        int answer = 0;
        for(int i=0; i<array.Length; i++)
        {
            if(array[i]%10==7)
            {
                answer++;
            }
        }
        for(int i=0; i<array.Length; i++)
        {
            while(array[i]>10)
            {
                array[i]/=10;
                if(array[i]%10==7)
                {
                    answer++;
                }
            
            }
        }
        return answer;
    }
}