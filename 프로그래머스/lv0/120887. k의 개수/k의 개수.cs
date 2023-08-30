using System;

public class Solution {
    public int solution(int i, int j, int k)
    {
                    int count = 0;
            
            int[] numbers = new int[j - i + 1];

            for(int a = 0; a< j-i+1; a++)
            {
                for(int b = i+a; b<=j; b++)
                {
                    numbers[a] = b;
                    break;
                }
            }
            for(int a = 0; a< numbers.Length; a++)
            {
                while (numbers[a] > 0)
                {
                    if (numbers[a]%10 == k)
                    {
                        count++;
                    }
                    numbers[a] /= 10;
                }
            }
        int answer = count;
        return answer;
    }
}