using System;

public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;
        int x = 0;
        int y = 0;
        while(n>=a)
        {

                x += n/a*b;
                y = (n%a);

            n = (n/a)*b + y;
        }
        answer = x;
        return answer;
    }
}