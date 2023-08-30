using System;

public class Solution {
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];
        if(num%2==0)
        {
            answer[num/2-1] = total/num;
            for(int i =num/2-2; i>=0; i--)
            {
                answer[i] = answer[i+1]-1;
            }
            for(int i = num/2; i<num; i++)
            {
                answer[i]=answer[i-1]+1;
            }
        }
        else if (num%2==1)
        {
            answer[num/2] = total/num;
            for(int i = num/2-1; i>=0; i--)
            {
                answer[i]=answer[i+1]-1;
            }
            for(int i=num/2+1; i<num; i++)
            {
                answer[i] = answer[i-1]+1;
            }
        }
        return answer;
    }
}