using System;

public class Solution {
    public int solution(int[] numbers, int k)
    {
            int answer = 1;

            if(numbers.Length%2 ==0)
            {
                for(int i=1; i<k; i++)
                {
                    if(answer == numbers[numbers.Length - 2])
                    {
                        answer = -1;
                    }
                    answer += 2;
                }
            }
            else if(numbers.Length%2 ==1)
            {
                for(int i=1; i<k; i++)
                {
                    
                    if (answer == numbers[numbers.Length - 1])
                    {
                        answer = 0;
                    }
                    else if(answer >= numbers[numbers.Length - 2])
                    {
                        answer = -1;
                    }
                    answer += 2;
                }
            }
        return answer;
    }
}