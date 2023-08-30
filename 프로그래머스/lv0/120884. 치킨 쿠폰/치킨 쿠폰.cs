using System;

public class Solution {
    public int solution(int chicken) 
    {
        int count = 0;
        int rest = 0;

        while(chicken > 0)
        {
            count = count + (chicken / 10);
            rest = rest + chicken % 10;
            if(rest>=10)
            {
                chicken = chicken+(rest/10);
            }
            chicken /= 10;
        }
        int answer = count + rest/10;
        return answer;
    }
}