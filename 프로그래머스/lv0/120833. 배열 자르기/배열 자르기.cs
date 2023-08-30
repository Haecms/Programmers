using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2)
    {
        int a = num2-num1+1;
        int[] answer = new int[a];
        
        for(int j=0; j<a; j++)
        {
            for(int i=num1+j; i<=num2; i++)
            {
                answer[j] = numbers[i];
                break;
            }
        }
        return answer;

    }
}